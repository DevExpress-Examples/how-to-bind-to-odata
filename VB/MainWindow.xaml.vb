Imports DevExpress.Data.Filtering
Imports DevExpress.Xpf.Data
Imports System
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Threading.Tasks
Imports System.Windows

Namespace InfiniteAsyncSourceODataSample
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			Dim source = New InfiniteAsyncSource() With {.ElementType = GetType(SCIssuesDemo)}
			AddHandler Me.Unloaded, Sub(o, e)
				source.Dispose()
			End Sub

			AddHandler source.FetchRows, Sub(o, e)
				e.Result = Task.Run(Function() FetchRows(e))
			End Sub

			AddHandler source.GetUniqueValues, Sub(o, e)
				e.Result = Task.Run(Function()
					Return GetUniqueValues(e.PropertyName)
				End Function)
			End Sub

			AddHandler source.GetTotalSummaries, Sub(o, e)
				e.Result = Task.Run(Function()
					Return GetSummaries(e.Filter, e.Summaries)
				End Function)
			End Sub

			grid.ItemsSource = source
		End Sub

		Private Shared Function FetchRows(ByVal e As FetchRowsAsyncEventArgs) As FetchRowsResult
			Dim queryable = GetIssueDataQueryable().SortBy(e.SortOrder, defaultUniqueSortPropertyName:= NameOf(SCIssuesDemo.Oid)).Where(MakeFilterExpression(e.Filter))

			Return queryable.Skip(e.Skip).Take(If(e.Take, 42)).ToArray()
		End Function

		Private Shared Function MakeFilterExpression(ByVal filter As CriteriaOperator) As Expression(Of Func(Of SCIssuesDemo, Boolean))
			Dim converter = New GridFilterCriteriaToExpressionConverter(Of SCIssuesDemo)()
			Return converter.Convert(filter)
		End Function

		Private Shared Function GetUniqueValues(ByVal propertyName As String) As Object()
			If propertyName = NameOf(SCIssuesDemo.TechnologyName) Then
				Return { ".NET", "ActiveX", "DX Services", "VCL", "VCL.NET" }
			End If
			Throw New InvalidOperationException()
		End Function

		Private Shared Function GetSummaries(ByVal filter As CriteriaOperator, ByVal summaries() As SummaryDefinition) As Object()
			Dim queryable = GetIssueDataQueryable().Where(MakeFilterExpression(filter))
			Return summaries.Select(Function(s) queryable.GetSingleSummary(s, New SingleSummaryOptions(useSortForMinMax:= True))).ToArray()
		End Function

		Private Shared Function GetIssueDataQueryable() As IQueryable(Of SCIssuesDemo)
			Dim context = New SCEntities(New Uri("https://demos.devexpress.com/Services/WcfLinqSC/WcfSCService.svc/"))
			Return context.SCIssuesDemo
		End Function
	End Class
End Namespace
