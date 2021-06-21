using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000C19 RID: 3097
	[Token(Token = "0x20007F5")]
	public class TextRecordParsing
	{
		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06004EC1 RID: 20161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000800")]
		public static IEnumerable<string> DefaultCommentPrefixes
		{
			[Token(Token = "0x6004187")]
			[Address(RVA = "0x23B54D0", Offset = "0x23B55D1", VA = "0x23B54D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004188")]
		[Address(RVA = "0x23B5630", Offset = "0x23B5731", VA = "0x23B5630")]
		public static string GetString(List<string> items, int index)
		{
			return null;
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x000191A0 File Offset: 0x000173A0
		[Token(Token = "0x6004189")]
		[Address(RVA = "0x23B56C0", Offset = "0x23B57C1", VA = "0x23B56C0")]
		public static bool GetBool(List<string> items, int index)
		{
			return default(bool);
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x000191B8 File Offset: 0x000173B8
		[Token(Token = "0x600418A")]
		[Address(RVA = "0x23B5830", Offset = "0x23B5931", VA = "0x23B5830")]
		public static bool GetInt(List<string> items, int index, ref int output)
		{
			return default(bool);
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x000191D0 File Offset: 0x000173D0
		[Token(Token = "0x600418B")]
		[Address(RVA = "0x23B58F0", Offset = "0x23B59F1", VA = "0x23B58F0")]
		public static bool GetFloat(List<string> items, int index, ref float output)
		{
			return default(bool);
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x000191E8 File Offset: 0x000173E8
		[Token(Token = "0x600418C")]
		[Address(RVA = "0x23B59B0", Offset = "0x23B5AB1", VA = "0x23B59B0")]
		public static bool GetVector3(List<string> items, int startIndex, ref Vector3 output)
		{
			return default(bool);
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418D")]
		[Address(RVA = "0x23B5AF0", Offset = "0x23B5BF1", VA = "0x23B5AF0")]
		public static List<TextRecordParsing.Record> ParseRecordsFromReader(TextReader reader, string entrySeparators = "\t,", [Optional] IEnumerable<string> commentPrefixes)
		{
			return null;
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418E")]
		[Address(RVA = "0x23B5FD0", Offset = "0x23B60D1", VA = "0x23B5FD0")]
		public static List<TextRecordParsing.Record> ParseRecordsFromFile(string sourcePath, Encoding encoding, string entrySeparators = "\t,", [Optional] IEnumerable<string> commentPrefixes)
		{
			return null;
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418F")]
		[Address(RVA = "0x23AF750", Offset = "0x23AF851", VA = "0x23AF750")]
		public static List<TextRecordParsing.Record> ParseRecordsFromText(string sourceText, string entrySeparators = "\t,", [Optional] IEnumerable<string> commentPrefixes)
		{
			return null;
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004190")]
		[Address(RVA = "0x23AF990", Offset = "0x23AFA91", VA = "0x23AF990")]
		public static List<TextRecordParsing.Record> GetSectionRecords(List<TextRecordParsing.Record> sourceRecords, string sectionName)
		{
			return null;
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x00019200 File Offset: 0x00017400
		[Token(Token = "0x6004191")]
		[Address(RVA = "0x23B5E50", Offset = "0x23B5F51", VA = "0x23B5E50")]
		private static bool LineIsCommentedOut(string trimmedLine, IEnumerable<string> commentPrefixes)
		{
			return default(bool);
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004192")]
		[Address(RVA = "0x23B6250", Offset = "0x23B6351", VA = "0x23B6250")]
		public TextRecordParsing()
		{
		}

		// Token: 0x0400AFC0 RID: 44992
		[Token(Token = "0x4008431")]
		public const string DefaultSeparators = "\t,";

		// Token: 0x02000C1A RID: 3098
		[Token(Token = "0x200139F")]
		public class Record
		{
			// Token: 0x06004ECD RID: 20173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007808")]
			[Address(RVA = "0x23B5F20", Offset = "0x23B6021", VA = "0x23B5F20")]
			public Record(IEnumerable<string> initialItems)
			{
			}

			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x06004ECE RID: 20174 RVA: 0x00019218 File Offset: 0x00017418
			[Token(Token = "0x17000DD8")]
			public int Count
			{
				[Token(Token = "0x6007809")]
				[Address(RVA = "0x23B64B0", Offset = "0x23B65B1", VA = "0x23B64B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A1D RID: 2589
			// (get) Token: 0x06004ECF RID: 20175 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000DD9")]
			public IEnumerable<string> Items
			{
				[Token(Token = "0x600780A")]
				[Address(RVA = "0x23B6500", Offset = "0x23B6601", VA = "0x23B6500")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004ED0 RID: 20176 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600780B")]
			[Address(RVA = "0x23AEBD0", Offset = "0x23AECD1", VA = "0x23AEBD0")]
			public string GetString(int index)
			{
				return null;
			}

			// Token: 0x06004ED1 RID: 20177 RVA: 0x00019230 File Offset: 0x00017430
			[Token(Token = "0x600780C")]
			[Address(RVA = "0x23B6510", Offset = "0x23B6611", VA = "0x23B6510")]
			public bool GetBool(int index)
			{
				return default(bool);
			}

			// Token: 0x06004ED2 RID: 20178 RVA: 0x00019248 File Offset: 0x00017448
			[Token(Token = "0x600780D")]
			[Address(RVA = "0x23B6520", Offset = "0x23B6621", VA = "0x23B6520")]
			public bool TryGetInt(int index, ref int output)
			{
				return default(bool);
			}

			// Token: 0x06004ED3 RID: 20179 RVA: 0x00019260 File Offset: 0x00017460
			[Token(Token = "0x600780E")]
			[Address(RVA = "0x23B65E0", Offset = "0x23B66E1", VA = "0x23B65E0")]
			public bool TryGetFloat(int index, ref float output)
			{
				return default(bool);
			}

			// Token: 0x06004ED4 RID: 20180 RVA: 0x00019278 File Offset: 0x00017478
			[Token(Token = "0x600780F")]
			[Address(RVA = "0x23B66A0", Offset = "0x23B67A1", VA = "0x23B66A0")]
			public bool TryGetVector3(int startIndex, ref Vector3 output)
			{
				return default(bool);
			}

			// Token: 0x06004ED5 RID: 20181 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007810")]
			[Address(RVA = "0x23B66B0", Offset = "0x23B67B1", VA = "0x23B66B0")]
			public Queue<string> ToQueue()
			{
				return null;
			}

			// Token: 0x0400AFC1 RID: 44993
			[Token(Token = "0x401B7D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private List<string> items;
		}

		// Token: 0x02000C1B RID: 3099
		[Token(Token = "0x20013A0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159610", Offset = "0x159711")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004ED7 RID: 20183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007812")]
			[Address(RVA = "0x23B62D0", Offset = "0x23B63D1", VA = "0x23B62D0")]
			public <>c()
			{
			}

			// Token: 0x06004ED8 RID: 20184 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007813")]
			[Address(RVA = "0x23B62E0", Offset = "0x23B63E1", VA = "0x23B62E0")]
			internal string <ParseRecordsFromReader>b__9_0(string item)
			{
				return null;
			}

			// Token: 0x06004ED9 RID: 20185 RVA: 0x00019290 File Offset: 0x00017490
			[Token(Token = "0x6007814")]
			[Address(RVA = "0x23B6300", Offset = "0x23B6401", VA = "0x23B6300")]
			internal bool <GetSectionRecords>b__12_1(TextRecordParsing.Record item)
			{
				return default(bool);
			}

			// Token: 0x0400AFC2 RID: 44994
			[Token(Token = "0x401B7DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly TextRecordParsing.<>c <>9;

			// Token: 0x0400AFC3 RID: 44995
			[Token(Token = "0x401B7DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__9_0;

			// Token: 0x0400AFC4 RID: 44996
			[Token(Token = "0x401B7DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<TextRecordParsing.Record, bool> <>9__12_1;
		}

		// Token: 0x02000C1C RID: 3100
		[Token(Token = "0x20013A1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159620", Offset = "0x159721")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x06004EDA RID: 20186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007815")]
			[Address(RVA = "0x23B6230", Offset = "0x23B6331", VA = "0x23B6230")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x06004EDB RID: 20187 RVA: 0x000192A8 File Offset: 0x000174A8
			[Token(Token = "0x6007816")]
			[Address(RVA = "0x23B63D0", Offset = "0x23B64D1", VA = "0x23B63D0")]
			internal bool <GetSectionRecords>b__0(TextRecordParsing.Record item)
			{
				return default(bool);
			}

			// Token: 0x0400AFC5 RID: 44997
			[Token(Token = "0x401B7DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sectionName;
		}

		// Token: 0x02000C1D RID: 3101
		[Token(Token = "0x20013A2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159630", Offset = "0x159731")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06004EDC RID: 20188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007817")]
			[Address(RVA = "0x23B6240", Offset = "0x23B6341", VA = "0x23B6240")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06004EDD RID: 20189 RVA: 0x000192C0 File Offset: 0x000174C0
			[Token(Token = "0x6007818")]
			[Address(RVA = "0x23B6470", Offset = "0x23B6571", VA = "0x23B6470")]
			internal bool <LineIsCommentedOut>b__0(string prefix)
			{
				return default(bool);
			}

			// Token: 0x0400AFC6 RID: 44998
			[Token(Token = "0x401B7DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string trimmedLine;
		}
	}
}
