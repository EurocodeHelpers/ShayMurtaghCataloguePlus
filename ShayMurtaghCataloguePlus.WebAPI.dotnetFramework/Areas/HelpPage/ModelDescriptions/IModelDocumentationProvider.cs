using System;
using System.Reflection;

namespace ShayMurtaghCataloguePlus.WebAPI.dotnetFramework.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}