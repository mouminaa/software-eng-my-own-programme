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

    using System;

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class BookingLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, YEAR=9, 
		NUMBER=10, MONTH=11, STRING=12, JAN=13, FEB=14, MAR=15, APR=16, MAY=17, 
		JUN=18, JUL=19, AUG=20, SEP=21, OCT=22, NOV=23, DEC=24, SEPARATOR=25, 
		COLON=26, WS=27;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "YEAR", 
		"NUMBER", "MONTH", "STRING", "JAN", "FEB", "MAR", "APR", "MAY", "JUN", 
		"JUL", "AUG", "SEP", "OCT", "NOV", "DEC", "SEPARATOR", "COLON", "WS"
	};


	public BookingLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'book'", "'a'", "'hotel'", "'room'", "'for'", "'guests'", "'on'", 
		"'and'", null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, "'-'", "':'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, "YEAR", "NUMBER", 
		"MONTH", "STRING", "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", 
		"SEP", "OCT", "NOV", "DEC", "SEPARATOR", "COLON", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Booking.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\x1D\xB0\b\x1\x4"+
		"\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b"+
		"\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4"+
		"\x10\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15"+
		"\t\x15\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A"+
		"\x4\x1B\t\x1B\x4\x1C\t\x1C\x3\x2\x3\x2\x3\x2\x3\x2\x3\x2\x3\x3\x3\x3\x3"+
		"\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x5\x3\x5\x3\x5\x3\x5\x3\x5\x3\x6"+
		"\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\a\x3\b\x3\b\x3\b\x3"+
		"\t\x3\t\x3\t\x3\t\x3\n\x3\n\x3\n\x3\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\f\x3"+
		"\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x5\fq\n\f\x3\r\x3\r\x6\ru\n"+
		"\r\r\r\xE\rv\x3\xE\x3\xE\x3\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3"+
		"\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3"+
		"\x12\x3\x13\x3\x13\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14\x3\x14\x3\x15\x3"+
		"\x15\x3\x15\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3"+
		"\x17\x3\x18\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3\x19\x3\x1A\x3"+
		"\x1A\x3\x1B\x3\x1B\x3\x1C\x3\x1C\x3\x1C\x3\x1C\x2\x2\x2\x1D\x3\x2\x3\x5"+
		"\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x13\x2\v\x15\x2"+
		"\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2\x11!\x2\x12#\x2\x13"+
		"%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19\x31\x2\x1A\x33\x2\x1B"+
		"\x35\x2\x1C\x37\x2\x1D\x3\x2\x18\x3\x2\x32;\x4\x2\x43\\\x63|\x4\x2LLl"+
		"l\x4\x2\x43\x43\x63\x63\x4\x2PPpp\x4\x2HHhh\x4\x2GGgg\x4\x2\x44\x44\x64"+
		"\x64\x4\x2OOoo\x4\x2TTtt\x4\x2RRrr\x4\x2[[{{\x4\x2WWww\x4\x2NNnn\x4\x2"+
		"IIii\x4\x2UUuu\x4\x2QQqq\x4\x2\x45\x45\x65\x65\x4\x2VVvv\x4\x2XXxx\x4"+
		"\x2\x46\x46\x66\x66\x5\x2\v\f\xF\xF\"\"\xBB\x2\x3\x3\x2\x2\x2\x2\x5\x3"+
		"\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2"+
		"\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15"+
		"\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2"+
		"\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2"+
		"\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2-"+
		"\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2\x2"+
		"\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x3\x39\x3\x2\x2\x2\x5>\x3\x2\x2\x2"+
		"\a@\x3\x2\x2\x2\t\x46\x3\x2\x2\x2\vK\x3\x2\x2\x2\rO\x3\x2\x2\x2\xFV\x3"+
		"\x2\x2\x2\x11Y\x3\x2\x2\x2\x13]\x3\x2\x2\x2\x15\x62\x3\x2\x2\x2\x17p\x3"+
		"\x2\x2\x2\x19r\x3\x2\x2\x2\x1Bx\x3\x2\x2\x2\x1D|\x3\x2\x2\x2\x1F\x80\x3"+
		"\x2\x2\x2!\x84\x3\x2\x2\x2#\x88\x3\x2\x2\x2%\x8C\x3\x2\x2\x2\'\x90\x3"+
		"\x2\x2\x2)\x94\x3\x2\x2\x2+\x98\x3\x2\x2\x2-\x9C\x3\x2\x2\x2/\xA0\x3\x2"+
		"\x2\x2\x31\xA4\x3\x2\x2\x2\x33\xA8\x3\x2\x2\x2\x35\xAA\x3\x2\x2\x2\x37"+
		"\xAC\x3\x2\x2\x2\x39:\a\x64\x2\x2:;\aq\x2\x2;<\aq\x2\x2<=\am\x2\x2=\x4"+
		"\x3\x2\x2\x2>?\a\x63\x2\x2?\x6\x3\x2\x2\x2@\x41\aj\x2\x2\x41\x42\aq\x2"+
		"\x2\x42\x43\av\x2\x2\x43\x44\ag\x2\x2\x44\x45\an\x2\x2\x45\b\x3\x2\x2"+
		"\x2\x46G\at\x2\x2GH\aq\x2\x2HI\aq\x2\x2IJ\ao\x2\x2J\n\x3\x2\x2\x2KL\a"+
		"h\x2\x2LM\aq\x2\x2MN\at\x2\x2N\f\x3\x2\x2\x2OP\ai\x2\x2PQ\aw\x2\x2QR\a"+
		"g\x2\x2RS\au\x2\x2ST\av\x2\x2TU\au\x2\x2U\xE\x3\x2\x2\x2VW\aq\x2\x2WX"+
		"\ap\x2\x2X\x10\x3\x2\x2\x2YZ\a\x63\x2\x2Z[\ap\x2\x2[\\\a\x66\x2\x2\\\x12"+
		"\x3\x2\x2\x2]^\x5\x15\v\x2^_\x5\x15\v\x2_`\x5\x15\v\x2`\x61\x5\x15\v\x2"+
		"\x61\x14\x3\x2\x2\x2\x62\x63\t\x2\x2\x2\x63\x16\x3\x2\x2\x2\x64q\x5\x1B"+
		"\xE\x2\x65q\x5\x1D\xF\x2\x66q\x5\x1F\x10\x2gq\x5!\x11\x2hq\x5#\x12\x2"+
		"iq\x5%\x13\x2jq\x5\'\x14\x2kq\x5)\x15\x2lq\x5+\x16\x2mq\x5-\x17\x2nq\x5"+
		"/\x18\x2oq\x5\x31\x19\x2p\x64\x3\x2\x2\x2p\x65\x3\x2\x2\x2p\x66\x3\x2"+
		"\x2\x2pg\x3\x2\x2\x2ph\x3\x2\x2\x2pi\x3\x2\x2\x2pj\x3\x2\x2\x2pk\x3\x2"+
		"\x2\x2pl\x3\x2\x2\x2pm\x3\x2\x2\x2pn\x3\x2\x2\x2po\x3\x2\x2\x2q\x18\x3"+
		"\x2\x2\x2rt\t\x3\x2\x2su\t\x3\x2\x2ts\x3\x2\x2\x2uv\x3\x2\x2\x2vt\x3\x2"+
		"\x2\x2vw\x3\x2\x2\x2w\x1A\x3\x2\x2\x2xy\t\x4\x2\x2yz\t\x5\x2\x2z{\t\x6"+
		"\x2\x2{\x1C\x3\x2\x2\x2|}\t\a\x2\x2}~\t\b\x2\x2~\x7F\t\t\x2\x2\x7F\x1E"+
		"\x3\x2\x2\x2\x80\x81\t\n\x2\x2\x81\x82\t\x5\x2\x2\x82\x83\t\v\x2\x2\x83"+
		" \x3\x2\x2\x2\x84\x85\t\x5\x2\x2\x85\x86\t\f\x2\x2\x86\x87\t\v\x2\x2\x87"+
		"\"\x3\x2\x2\x2\x88\x89\t\n\x2\x2\x89\x8A\t\x5\x2\x2\x8A\x8B\t\r\x2\x2"+
		"\x8B$\x3\x2\x2\x2\x8C\x8D\t\x4\x2\x2\x8D\x8E\t\xE\x2\x2\x8E\x8F\t\x6\x2"+
		"\x2\x8F&\x3\x2\x2\x2\x90\x91\t\x4\x2\x2\x91\x92\t\xE\x2\x2\x92\x93\t\xF"+
		"\x2\x2\x93(\x3\x2\x2\x2\x94\x95\t\x5\x2\x2\x95\x96\t\xE\x2\x2\x96\x97"+
		"\t\x10\x2\x2\x97*\x3\x2\x2\x2\x98\x99\t\x11\x2\x2\x99\x9A\t\b\x2\x2\x9A"+
		"\x9B\t\f\x2\x2\x9B,\x3\x2\x2\x2\x9C\x9D\t\x12\x2\x2\x9D\x9E\t\x13\x2\x2"+
		"\x9E\x9F\t\x14\x2\x2\x9F.\x3\x2\x2\x2\xA0\xA1\t\x6\x2\x2\xA1\xA2\t\x12"+
		"\x2\x2\xA2\xA3\t\x15\x2\x2\xA3\x30\x3\x2\x2\x2\xA4\xA5\t\x16\x2\x2\xA5"+
		"\xA6\t\b\x2\x2\xA6\xA7\t\x13\x2\x2\xA7\x32\x3\x2\x2\x2\xA8\xA9\a/\x2\x2"+
		"\xA9\x34\x3\x2\x2\x2\xAA\xAB\a<\x2\x2\xAB\x36\x3\x2\x2\x2\xAC\xAD\t\x17"+
		"\x2\x2\xAD\xAE\x3\x2\x2\x2\xAE\xAF\b\x1C\x2\x2\xAF\x38\x3\x2\x2\x2\x5"+
		"\x2pv\x3\x2\x3\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Antlr.Content
