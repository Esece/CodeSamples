###### Microsoft.CSharp.CSharpCodeProvider
## CSharpCodeProvider

Generate Code
``` csharp
var options = new CodeGeneratorOptions();
options.BracingStyle = "C";
options.IndentString = "    ";

var method1 = new CodeMemberMethod();
method1.Name = "ReturnString";

method1.Attributes = MemberAttributes.Public | MemberAttributes.Final;
method1.ReturnType = new CodeTypeReference("System.String");
method1.Parameters.Add(new CodeParameterDeclarationExpression("System.String", "text"));
method1.Statements.Add(new CodeMethodReturnStatement(new CodeArgumentReferenceExpression("text")));

method1.Statements.Add(new CodeVariableDeclarationStatement("Moq", "moq"));


var sw = new StringWriter();
new CSharpCodeProvider().GenerateCodeFromMember(method1, sw, options);

var code = new CodeSnippetTypeMember(sw.ToString());
```

Output
``` 
public string ReturnString(string text)
{
    return text;
    Moq moq;
}
```
