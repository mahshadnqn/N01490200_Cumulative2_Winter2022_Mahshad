using System;

namespace N01490200_Cumulative2_Winter2022_Mahshad.Areas.HelpPage.ModelDescriptions
{
    /// <summary>
    /// Use this attribute to change the name of the <see cref="ModelDescription"/> generated for a type.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum, AllowMultiple = false, Inherited = false)]
    public sealed class ModelNameAttribute : Attribute
    {
        public ModelNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}