using OppgaveGeneriskeTyper.Classes;


namespace Tests;

public class RepositoryTests
{
    [Fact]
    public void TestCreateRepository()
    {
        // Arrange
        var repository = new Repository<string>();

        // Act

        // Assert
        Assert.NotNull(repository);
    }
    [Fact]
    public void TestAddItem()
    {
        // Arrange
        var repository = new Repository<string>();

        // Act
        repository.Add("God");
        repository.Add("Gamer");

        // Assert
        var all = repository.GetAll().ToList();
        Assert.Contains("God", all);
        Assert.Contains("Gamer", all);
        Assert.Equal(2, all.Count);
    }
    [Fact]
    public void TestReturnsMatchingItems()
    {
        // Arrange
        var repository = new Repository<int>();

        
        // Act
        repository.Add(67); 
        repository.Add(68);
        repository.Add(69);

        // Assert
        Assert.Equal(67, repository.GetById(0));
        Assert.Equal(68, repository.GetById(1));
        Assert.Equal(69, repository.GetById(2));

    }
    [Fact]
    public void TestRemoveItem()
    {
        // Arrange 
        var repository = new Repository<int>();

        repository.Add(67);
        repository.Add(68);
        repository.Add(69);

        // Act 

        repository.Remove(68);
        
        // Assert
        var all = repository.GetAll().ToList();

        Assert.Equal(2, all.Count);
        Assert.Equal(67, repository.GetById(0));
        Assert.Equal(69, repository.GetById(1));
        Assert.False(all.Exists(x => x == 68));
    }
    [Fact]
    public void TestUpdateItem()
    {
        // Arrange
        var repository = new Repository<int>();

        repository.Add(4);
        repository.Add(5);
        repository.Add(67);

        // Act 
        repository.Update(1337, 0);
        repository.Update(123, 1);

        // Assert
        var all = repository.GetAll().ToList();

        Assert.Equal(3, all.Count);
        Assert.Equal(1337, all[0]);
        Assert.Equal(123, all[1]);
        Assert.Equal(67, all[2]);
    }
    [Fact]
    public void TestGetByIdThrowsIndexOutOfRangeException()
    {
        // Arrange
        var repository = new Repository<string>();

        // Act
        repository.Add("C#");
        repository.Add("Java");

        // Assert
        Assert.Throws<IndexOutOfRangeException>(() => repository.GetById(2));

    }
    [Fact]
    public void TestUpdateThrowsIndexOutOfRangeException()
    {
        // Arrange
        var repository = new Repository<string>();

        // Act
        repository.Add("Python");
        repository.Add("Javascript");
    
        // Assert
        Assert.Throws<IndexOutOfRangeException>(() => repository.Update("Rust", 2));

    }
}
