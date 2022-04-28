Console.WriteLine();


[OldType(typeof(bool))]
bool Method1() => true;

[NewType<bool>]
bool Method2() => true;




public class OldTypeAttribute : Attribute
{
    public Type ParamType { get; }

    public OldTypeAttribute(Type t) => ParamType = t;
}



public class NewTypeAttribute<T> : Attribute where T : struct
{
    public Type ParamType { get; }

    public NewTypeAttribute() => ParamType = typeof(T);
}