using OppgaveGeneriskeTyper.Classes;


namespace Tests;

public class StackTests
{
    [Fact]
    public void TestCreateStack()
    {
        // Act
        var TestStack = new Stacks<int>(10);
        // Assert
        Assert.NotNull(TestStack);
    }
    [Fact]
    public void TestPushPopItem()
    {
        // Arrange
        var TestStack = new Stacks<int>(10);

    
        // Act
        TestStack.Push(67);
        TestStack.Push(68);

        // Assert
        Assert.Equal(68, TestStack.Pop());
        Assert.Equal(67, TestStack.Pop());
    }
    [Fact]
    public void TestPopEmptyStackThrowsIndexOutOfRangeException()
    {
        // Arrange
        var TestStack = new Stacks<int>(10);

        // Act
        
    
        // Assert
        Assert.Throws<IndexOutOfRangeException>(() => TestStack.Pop());
    }
    [Fact]
    public void TestPushOverflowThrowsIndexOutOfRangeException()
    {
        // Arrange
        var TestStack = new Stacks<int>(2);

        // Act
        TestStack.Push(1);
        TestStack.Push(2);

        // Assert
        Assert.Throws<IndexOutOfRangeException>(() => TestStack.Push(3));
    }
}