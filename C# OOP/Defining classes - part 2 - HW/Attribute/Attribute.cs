using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

[AttributeUsage(
    AttributeTargets.Struct |
    AttributeTargets.Class |
    AttributeTargets.Interface |
    AttributeTargets.Method |
    AttributeTargets.Enum
)]
class VersionAttribute : System.Attribute
{
    public string Version { get; private set; }

    public VersionAttribute(string version)
    {
        this.Version = version;
    }

    public override string ToString()
    {
        return this.Version;
    }
}
