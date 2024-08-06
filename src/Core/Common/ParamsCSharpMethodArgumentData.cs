﻿namespace Paraminter.CSharp.Method.Hesychia.Common;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Paraminter.Arguments.CSharp.Method.Models;

using System.Collections.Generic;

internal sealed class ParamsCSharpMethodArgumentData
    : IParamsCSharpMethodArgumentData
{
    private readonly IReadOnlyList<ArgumentSyntax> SyntacticArguments;

    public ParamsCSharpMethodArgumentData(
        IReadOnlyList<ArgumentSyntax> syntacticArguments)
    {
        SyntacticArguments = syntacticArguments;
    }

    IReadOnlyList<ArgumentSyntax> IParamsCSharpMethodArgumentData.SyntacticArguments => SyntacticArguments;
}
