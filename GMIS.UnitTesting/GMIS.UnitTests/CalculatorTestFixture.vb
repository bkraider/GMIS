Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports GMIS.Business

<TestClass()>
Public Class CalculatorTestFixture

    Private m_SystemUnderTest As Calculator

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public ReadOnly Property SystemUnderTest() As Calculator
        Get
            If m_SystemUnderTest Is Nothing Then
                m_SystemUnderTest = New Calculator()
            End If
            Return m_SystemUnderTest
        End Get

    End Property

#Region "Additional test attributes"
    '
    ' You can use the following additional attributes as you write your tests:
    '
    ' Use ClassInitialize to run code before running the first test in the class
    <ClassInitialize()>
    Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    End Sub
    '
    ' Use TestInitialize to run code before running each test
    <TestInitialize()>
    Public Sub MyTestInitialize()
    End Sub
    '
    ' Use ClassCleanup to run code after all tests in a class have run
    <ClassCleanup()>
    Public Shared Sub MyClassCleanup()
    End Sub
    '
    ' Use TestCleanup to run code after each test has run
    <TestCleanup()>
    Public Sub MyTestCleanup()
        m_SystemUnderTest = Nothing
    End Sub

#End Region

    <TestMethod()>
    Public Sub Add()
        'Dim calc As New Calculator
        Dim expected As Integer = 5
        Dim actual As Integer = 0
        actual = SystemUnderTest.Add(2, 3)
        Assert.AreEqual(expected, actual, "Did not get the right value from the add method")
    End Sub

    <TestMethod()>
    Public Sub Subtract()
        'Dim calc As New Calculator
        Dim expected As Integer = 2
        Dim actual As Integer = 0
        actual = SystemUnderTest.Subtract(3, 2)
        Assert.AreEqual(expected, actual, "Did not get the right value from the subtract method")
    End Sub

    <TestMethod()>
    Public Sub Multiply()
        'Dim calc As New Calculator
        Dim expected As Integer = 5
        Dim actual As Integer = 0
        actual = SystemUnderTest.Multiply(2, 3)
        Assert.AreEqual(expected, actual, "Did not get the right value from the multiply method")
    End Sub

    <TestMethod()>
    Public Sub Divide()
        'Dim calc As New Calculator
        Dim expected As Integer = 3
        Dim actual As Integer = 0
        actual = SystemUnderTest.Divide(9, 3)
        Assert.AreEqual(expected, actual, "Did not get the right value from the divide method")
    End Sub


End Class
