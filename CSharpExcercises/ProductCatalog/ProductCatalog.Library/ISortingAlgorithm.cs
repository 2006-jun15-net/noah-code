namespace ProductCatalog.Library
{ 
    public interface ISortingAlgorithm<TCollection>
    {
         void Sort(TCollection collection);
    }
}