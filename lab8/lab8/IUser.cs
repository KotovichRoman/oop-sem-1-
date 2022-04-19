using System.ComponentModel;

namespace lab8
{
    public interface IUser<T> where T : class
    {
        public void Add(T elem);
        public void Remove(T elem);
        public void View();
    }
}