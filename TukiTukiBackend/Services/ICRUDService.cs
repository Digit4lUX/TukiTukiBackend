namespace TukiTukiBackend.Services;

public interface ICRUDService<T>
{
    public IEnumerable<T> getAll();
    public T? getById(int id);
    public T create(T item);
    public void delete(int id);
}