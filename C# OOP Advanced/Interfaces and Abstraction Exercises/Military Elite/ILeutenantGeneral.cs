using System.Collections.Generic;

namespace Military_Elite
{
    public interface ILeutenantGeneral
    {
        List<Private> PrivatesUnderCommand { get; }
    }
}
