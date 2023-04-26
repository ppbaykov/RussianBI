//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from RussianBIGrammar.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="RussianBIGrammarParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public interface IRussianBIGrammarVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="RussianBIGrammarParser.root"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRoot([NotNull] RussianBIGrammarParser.RootContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RussianBIGrammarParser.groupByFunction"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroupByFunction([NotNull] RussianBIGrammarParser.GroupByFunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RussianBIGrammarParser.column"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitColumn([NotNull] RussianBIGrammarParser.ColumnContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RussianBIGrammarParser.groupByColumns"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroupByColumns([NotNull] RussianBIGrammarParser.GroupByColumnsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RussianBIGrammarParser.groupByCalculations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroupByCalculations([NotNull] RussianBIGrammarParser.GroupByCalculationsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RussianBIGrammarParser.groupByCalculation"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitGroupByCalculation([NotNull] RussianBIGrammarParser.GroupByCalculationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RussianBIGrammarParser.sumFunc"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSumFunc([NotNull] RussianBIGrammarParser.SumFuncContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="RussianBIGrammarParser.measureName"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMeasureName([NotNull] RussianBIGrammarParser.MeasureNameContext context);
}
