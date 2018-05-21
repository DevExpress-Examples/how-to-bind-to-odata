using DevExpress.Data.Filtering;
using DevExpress.Xpf.Data;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows;

namespace InfiniteAsyncSourceODataSample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            var source = new InfiniteAsyncSource() {
                ElementType = typeof(SCIssuesDemo)
            };
            Unloaded += (o, e) => {
                source.Dispose();
            };

            source.FetchRows += (o, e) => {
                e.Result = Task.Run(() => FetchRows(e));
            };

            source.GetUniqueValues += (o, e) => {
                e.Result = Task.Run(() => {
                    return GetUniqueValues(e.PropertyName);
                });
            };

            source.GetTotalSummaries += (o, e) => {
                e.Result = Task.Run(() => {
                    return GetSummaries(e.Filter, e.Summaries);
                });
            };

            grid.ItemsSource = source;
        }

        static FetchRowsResult FetchRows(FetchRowsAsyncEventArgs e) {
            var queryable = GetIssueDataQueryable()
                .SortBy(e.SortOrder, defaultUniqueSortPropertyName: nameof(SCIssuesDemo.Oid))
                .Where(MakeFilterExpression(e.Filter));

            return queryable
                .Skip(e.Skip)
                .Take(42)
                .ToArray();
        }

        static Expression<Func<SCIssuesDemo, bool>> MakeFilterExpression(CriteriaOperator filter) {
            var converter = new GridFilterCriteriaToExpressionConverter<SCIssuesDemo>();
            return converter.Convert(filter);
        }

        static object[] GetUniqueValues(string propertyName) {
            if(propertyName == nameof(SCIssuesDemo.TechnologyName))
                return new[] { ".NET", "ActiveX", "DX Services", "VCL", "VCL.NET" };
            throw new InvalidOperationException();
        }

        static object[] GetSummaries(CriteriaOperator filter, SummaryDefinition[] summaries) {
            var queryable = GetIssueDataQueryable()
                .Where(MakeFilterExpression(filter));
            return summaries
                .Select(s => queryable.GetSingleSummary(s, new SingleSummaryOptions(useSortForMinMax: true)))
                .ToArray();
        }

        static IQueryable<SCIssuesDemo> GetIssueDataQueryable() {
            var context = new SCEntities(new Uri("https://demos.devexpress.com/Services/WcfLinqSC/WcfSCService.svc/"));
            return context.SCIssuesDemo;
        }
    }
}
