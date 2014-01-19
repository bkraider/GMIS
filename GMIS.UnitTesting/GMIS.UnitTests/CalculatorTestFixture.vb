Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports GMIS.Business

<TestClass()>
Public Class CalculatorTestFixture

    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = value
        End Set
    End Property

#Region "Additional test attributes"
    '
    ' You can use the following additional attributes as you write your tests:
    '
    ' Use ClassInitialize to run code before running the first test in the class
    ' <ClassInitialize()> Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    ' End Sub
    '
    ' Use ClassCleanup to run code after all tests in a class have run
    ' <ClassCleanup()> Public Shared Sub MyClassCleanup()
    ' End Sub
    '
    ' Use TestInitialize to run code before running each test
    ' <TestInitialize()> Public Sub MyTestInitialize()
    ' End Sub
    '
    ' Use TestCleanup to run code after each test has run
    ' <TestCleanup()> Public Sub MyTestCleanup()
    ' End Sub
    '
#End Region

    <TestMethod()>
    Public Sub Add()
        Dim calc As New Calculator
        Dim result As Integer = 0
        result = calc.Add(2, 3)
        Assert.AreEqual(result, 5)
    End Sub

    <TestMethod()>
    Public Sub Subtract()
        Dim calc As New Calculator
        Dim result As Integer = 0
        result = calc.Subtract(3, 2)
        Assert.AreEqual(result, 1)
    End Sub

    <TestMethod()>
    Public Sub Multiply()
        Dim calc As New Calculator
        Dim result As Integer = 0
        result = calc.Multiply(2, 3)
        Assert.AreEqual(result, 6)
    End Sub

    <TestMethod()>
    Public Sub Divide()
        Dim calc As New Calculator
        Dim result As Integer = 0
        result = calc.Divide(3, 3)
        Assert.AreEqual(result, 1)
    End Sub

End Class
