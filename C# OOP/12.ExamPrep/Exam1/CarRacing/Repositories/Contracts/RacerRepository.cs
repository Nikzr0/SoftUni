namespace CarRacing.Repositories.Contracts
{
    public class RacerRepository : IRepository<T>
    {
        public System.Collections.Generic.IReadOnlyCollection<T> Models => throw new System.NotImplementedException();

        public void Add(T model)
        {
            throw new System.NotImplementedException();
        }

        public T FindBy(string property)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T model)
        {
            throw new System.NotImplementedException();
        }
    }
}
