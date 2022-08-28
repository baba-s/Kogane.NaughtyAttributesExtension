# Kogane Naughty Attributes Extension

NaughtyAttributes を拡張するパッケージ

## 使用例

### Before

```csharp
using NaughtyAttributes;
using UnityEngine;

public class Example : MonoBehaviour
{
    [Button( enabledMode: EButtonEnableMode.Playmode )]
    private void Play1()
    {
    }

    [Button( enabledMode: EButtonEnableMode.Editor )]
    private void Play2()
    {
    }
}
```

### After

```csharp
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    [ButtonEnableIfPlayMode]
    private void Play1()
    {
    }

    [ButtonEnableIfEditMode]
    private void Play2()
    {
    }
}
```