﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\zhout\source\repos\momo2\Antlr\Content\Booking.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Antlr.Content {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IBookingListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class BookingBaseListener : IBookingListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="BookingParser.booking"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooking([NotNull] BookingParser.BookingContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BookingParser.booking"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooking([NotNull] BookingParser.BookingContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="BookingParser.time"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTime([NotNull] BookingParser.TimeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BookingParser.time"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTime([NotNull] BookingParser.TimeContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="BookingParser.person"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPerson([NotNull] BookingParser.PersonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BookingParser.person"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPerson([NotNull] BookingParser.PersonContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="BookingParser.firstName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFirstName([NotNull] BookingParser.FirstNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BookingParser.firstName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFirstName([NotNull] BookingParser.FirstNameContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="BookingParser.lastName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLastName([NotNull] BookingParser.LastNameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BookingParser.lastName"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLastName([NotNull] BookingParser.LastNameContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="BookingParser.numberOfGuests"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberOfGuests([NotNull] BookingParser.NumberOfGuestsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BookingParser.numberOfGuests"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberOfGuests([NotNull] BookingParser.NumberOfGuestsContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="BookingParser.datetime"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDatetime([NotNull] BookingParser.DatetimeContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="BookingParser.datetime"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDatetime([NotNull] BookingParser.DatetimeContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Antlr.Content
