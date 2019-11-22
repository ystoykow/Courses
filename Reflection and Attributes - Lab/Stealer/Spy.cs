using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    private StringBuilder result;
    public Spy()
    {
        this.result = new StringBuilder();
    }

    public string StealFieldInfo(string nameOfClass, params string[] nameOfFields)
    {

        Type typeOfClass = Type.GetType(nameOfClass);
        FieldInfo[] classFields = typeOfClass
                .GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic |
                                  BindingFlags.Public);
        Object classInstance = Activator.CreateInstance(typeOfClass, new object[] { });
        this.result.AppendLine($"Class under investigation: {nameOfClass}");

        foreach (var field in classFields.Where(f => nameOfFields.Contains(f.Name)))
        {
            this.result.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return this.result.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string nameOfClass)
    {
        Type classType = Type.GetType(nameOfClass);
        FieldInfo[] fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        foreach (var field in fields)
        {
            this.result.AppendLine($"{field.Name} must be private!");
        }

        MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (var method in classPublicMethods.Where(m => m.Name.StartsWith("get")))
        {
            this.result.AppendLine($"{method.Name} have to be public!");
        }

        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        foreach (var method in classNonPublicMethods.Where(m => m.Name.StartsWith("set")))
        {
            this.result.AppendLine($"{method.Name} have to be private!");
        }

        return this.result.ToString().Trim();
    }

    public string RevealPrivateMethods(string nameOfClass)
    {
        Type classType = Type.GetType(nameOfClass);
        MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);


        this.result.AppendLine($"All Private Methods of Class: {nameOfClass}");
        this.result.AppendLine($"Base Class: {classType.BaseType.Name}");
        foreach (var method in privateMethods)
        {
            this.result.AppendLine($"{method.Name}");
        }

        return this.result.ToString().Trim();
    }

    public string CollectGettersAndSetters(string nameOfClass)
    {
        Type classType = Type.GetType(nameOfClass);
        MethodInfo[] allMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

        foreach (var method in allMethods.Where(m => m.Name.StartsWith("get")))
        {
            this.result.AppendLine($"{method.Name} will return {method.ReturnType}");
        }

        foreach (var method in allMethods.Where(m => m.Name.StartsWith("set")))
        {
            this.result.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");
        }

        return this.result.ToString().Trim();
    }
}

