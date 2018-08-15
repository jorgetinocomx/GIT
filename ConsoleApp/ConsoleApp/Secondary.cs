namespace ConsoleApp
{
    public class Secondary
    {
        /// <summary>
        /// Create an instance of <see cref="Entity"/> type.
        /// </summary>
        /// <returns> <see cref="Entity"/> objec.t</returns>
        internal Entity CreateInstance()
        {
            var NewInstance = new Entity();
            NewInstance.Identifier = 1;
            NewInstance.Description = "Test description";
            return NewInstance;
        }
    }
}
