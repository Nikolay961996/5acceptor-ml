using System;

namespace Eurofurence.App.Common.DependencyResolution
{
    public class IocBeacon : Attribute
    {
        //# CA1711: Идентификаторы не должны иметь неверных суффиксов
        public enum EnvironmentEnum
        {
            Any = 0,
            DesignTimeOnly = 1,
            RunTimeOnly = 2
        }

        // # CA1711: Идентификаторы не должны иметь неверных суффиксов
        public enum ScopeEnum
        {
            AlwaysUnique = 0,
            Singleton = 1,
            Transient = 2
        }

        public Type TargetType { get; set; }
        public ScopeEnum Scope { get; set; }
        public EnvironmentEnum Environment { get; set; }
    }
}