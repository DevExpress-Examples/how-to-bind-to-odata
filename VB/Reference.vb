﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.237
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

' Original file name:
' Generation date: 22.09.2011 16:28:11
Namespace InfiniteAsyncSourceODataSample

    ''' <summary>
    ''' There are no comments for SCEntities in the schema.
    ''' </summary>
    Partial Public Class SCEntities
        Inherits System.Data.Services.Client.DataServiceContext

        ''' <summary>
        ''' Initialize a new SCEntities object.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Sub New(ByVal serviceRoot As Global.System.Uri)
            MyBase.New(serviceRoot)
            Me.ResolveName = New Global.System.Func(Of Global.System.Type, String)(AddressOf Me.ResolveNameFromType)
            Me.ResolveType = New Global.System.Func(Of String, Global.System.Type)(AddressOf Me.ResolveTypeFromName)
            Me.OnContextCreated()
        End Sub
        Partial Private Sub OnContextCreated()
        End Sub
        ''' <summary>
        ''' Since the namespace configured for this service reference
        ''' in Visual Studio is different from the one indicated in the
        ''' server schema, use type-mappers to map between the two.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Protected Function ResolveTypeFromName(ByVal typeName As String) As Global.System.Type
            If typeName.StartsWith("SCModel", Global.System.StringComparison.Ordinal) Then
                Return Me.GetType().Assembly.GetType(String.Concat("GridDemo.WcfSCService", typeName.Substring(17)), False)
            End If
            Return Nothing
        End Function
        ''' <summary>
        ''' Since the namespace configured for this service reference
        ''' in Visual Studio is different from the one indicated in the
        ''' server schema, use type-mappers to map between the two.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Protected Function ResolveNameFromType(ByVal clientType As Global.System.Type) As String
            If clientType.Namespace.Equals("GridDemo.WcfSCService", Global.System.StringComparison.Ordinal) Then
                Return String.Concat("SCModel.", clientType.Name)
            End If
            Return Nothing
        End Function
        ''' <summary>
        ''' There are no comments for SCIssuesDemo in the schema.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public ReadOnly Property SCIssuesDemo() As Global.System.Data.Services.Client.DataServiceQuery(Of SCIssuesDemo)
            Get
                If (Me._SCIssuesDemo Is Nothing) Then
                    Me._SCIssuesDemo = MyBase.CreateQuery(Of SCIssuesDemo)("SCIssuesDemo")
                End If
                Return Me._SCIssuesDemo
            End Get
        End Property
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _SCIssuesDemo As Global.System.Data.Services.Client.DataServiceQuery(Of SCIssuesDemo)
        ''' <summary>
        ''' There are no comments for SCIssuesDemo in the schema.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Sub AddToSCIssuesDemo(ByVal SCIssuesDemo As SCIssuesDemo)
            MyBase.AddObject("SCIssuesDemo", SCIssuesDemo)
        End Sub
    End Class
    ''' <summary>
    ''' There are no comments for SCModel.SCIssuesDemo in the schema.
    ''' </summary>
    ''' <KeyProperties>
    ''' Oid
    ''' </KeyProperties>
    <Global.System.Data.Services.Common.EntitySetAttribute("SCIssuesDemo"), Global.System.Data.Services.Common.DataServiceKeyAttribute("Oid")> _
    Partial Public Class SCIssuesDemo
        Implements System.ComponentModel.INotifyPropertyChanged

        ''' <summary>
        ''' Create a new SCIssuesDemo object.
        ''' </summary>
        ''' <param name="oid">Initial value of Oid.</param>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Shared Function CreateSCIssuesDemo(ByVal oid As Global.System.Guid) As SCIssuesDemo
            Dim SCIssuesDemo As New SCIssuesDemo()
            SCIssuesDemo.Oid = oid
            Return SCIssuesDemo
        End Function
        ''' <summary>
        ''' There are no comments for Property Oid in the schema.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property Oid() As Global.System.Guid
            Get
                Return Me._Oid
            End Get
            Set(ByVal value As System.Guid)
                Me.OnOidChanging(value)
                Me._Oid = value
                Me.OnOidChanged()
                Me.OnPropertyChanged("Oid")
            End Set
        End Property
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _Oid As Global.System.Guid
        Partial Private Sub OnOidChanging(ByVal value As Global.System.Guid)
        End Sub
        Partial Private Sub OnOidChanged()
        End Sub
        ''' <summary>
        ''' There are no comments for Property ID in the schema.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property ID() As String
            Get
                Return Me._ID
            End Get
            Set(ByVal value As String)
                Me.OnIDChanging(value)
                Me._ID = value
                Me.OnIDChanged()
                Me.OnPropertyChanged("ID")
            End Set
        End Property
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _ID As String
        Partial Private Sub OnIDChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnIDChanged()
        End Sub
        ''' <summary>
        ''' There are no comments for Property Subject in the schema.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property Subject() As String
            Get
                Return Me._Subject
            End Get
            Set(ByVal value As String)
                Me.OnSubjectChanging(value)
                Me._Subject = value
                Me.OnSubjectChanged()
                Me.OnPropertyChanged("Subject")
            End Set
        End Property
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _Subject As String
        Partial Private Sub OnSubjectChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnSubjectChanged()
        End Sub
        ''' <summary>
        ''' There are no comments for Property ModifiedOn in the schema.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property ModifiedOn() As Global.System.DateTime?
            Get
                Return Me._ModifiedOn
            End Get
            Set(ByVal value? As Date)
                Me.OnModifiedOnChanging(value)
                Me._ModifiedOn = value
                Me.OnModifiedOnChanged()
                Me.OnPropertyChanged("ModifiedOn")
            End Set
        End Property
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _ModifiedOn? As Global.System.DateTime
        Partial Private Sub OnModifiedOnChanging(ByVal value? As Global.System.DateTime)
        End Sub
        Partial Private Sub OnModifiedOnChanged()
        End Sub
        ''' <summary>
        ''' There are no comments for Property CreatedOn in the schema.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property CreatedOn() As Global.System.DateTime?
            Get
                Return Me._CreatedOn
            End Get
            Set(ByVal value? As Date)
                Me.OnCreatedOnChanging(value)
                Me._CreatedOn = value
                Me.OnCreatedOnChanged()
                Me.OnPropertyChanged("CreatedOn")
            End Set
        End Property
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _CreatedOn? As Global.System.DateTime
        Partial Private Sub OnCreatedOnChanging(ByVal value? As Global.System.DateTime)
        End Sub
        Partial Private Sub OnCreatedOnChanged()
        End Sub
        ''' <summary>
        ''' There are no comments for Property ProductName in the schema.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property ProductName() As String
            Get
                Return Me._ProductName
            End Get
            Set(ByVal value As String)
                Me.OnProductNameChanging(value)
                Me._ProductName = value
                Me.OnProductNameChanged()
                Me.OnPropertyChanged("ProductName")
            End Set
        End Property
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _ProductName As String
        Partial Private Sub OnProductNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnProductNameChanged()
        End Sub
        ''' <summary>
        ''' There are no comments for Property TechnologyName in the schema.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property TechnologyName() As String
            Get
                Return Me._TechnologyName
            End Get
            Set(ByVal value As String)
                Me.OnTechnologyNameChanging(value)
                Me._TechnologyName = value
                Me.OnTechnologyNameChanged()
                Me.OnPropertyChanged("TechnologyName")
            End Set
        End Property
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _TechnologyName As String
        Partial Private Sub OnTechnologyNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnTechnologyNameChanged()
        End Sub
        ''' <summary>
        ''' There are no comments for Property Urgent in the schema.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property Urgent() As Boolean?
            Get
                Return Me._Urgent
            End Get
            Set(ByVal value? As Boolean)
                Me.OnUrgentChanging(value)
                Me._Urgent = value
                Me.OnUrgentChanged()
                Me.OnPropertyChanged("Urgent")
            End Set
        End Property
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _Urgent? As Boolean
        Partial Private Sub OnUrgentChanging(ByVal value? As Boolean)
        End Sub
        Partial Private Sub OnUrgentChanged()
        End Sub
        ''' <summary>
        ''' There are no comments for Property Status in the schema.
        ''' </summary>
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Property Status() As String
            Get
                Return Me._Status
            End Get
            Set(ByVal value As String)
                Me.OnStatusChanging(value)
                Me._Status = value
                Me.OnStatusChanged()
                Me.OnPropertyChanged("Status")
            End Set
        End Property
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Private _Status As String
        Partial Private Sub OnStatusChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnStatusChanged()
        End Sub
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
        Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
            RaiseEvent PropertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
        End Sub
    End Class
End Namespace
