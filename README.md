# Unity_SceneObject

<img src="https://github.com/XJINE/Unity_SceneObject/blob/main/Screenshot.png" width="100%" height="auto" />

Setup SceneAsset in Inspector & load it runtime.

## Importing

You can use Package Manager or import it directly.

```
https://github.com/XJINE/Unity_SceneObject.git?path=Assets/Packages/SceneObject
```

## How to Use

```csharp
public class Sample : MonoBehaviour
{
    public SceneObject sceneObject;
    ~
    SceneManager.LoadScene(sceneObject.Path);
    ~
}
```

Scene must be setup in "build settings" if you want to load in runtime.

## References

Original idea is here.
https://gist.github.com/Hertzole/ac269f3148bc5192cc2eb6d472870d24
