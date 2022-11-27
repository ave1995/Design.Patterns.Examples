namespace DesignPatterns.Builder.FunctionalBuilder
{
    public static class EmployeeBuilderExtensions
    {
        public static EmployeeBuilder WorksAsA
            (this EmployeeBuilder builder, string position) 
            => builder.Do(p => p.Position = position);
    }
}
