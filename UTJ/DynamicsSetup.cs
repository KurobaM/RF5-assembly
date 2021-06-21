using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BD8 RID: 3032
	[Token(Token = "0x20007E3")]
	public class DynamicsSetup
	{
		// Token: 0x06004D5C RID: 19804 RVA: 0x00018A98 File Offset: 0x00016C98
		[Token(Token = "0x60040E5")]
		[Address(RVA = "0x2127AC0", Offset = "0x2127BC1", VA = "0x2127AC0")]
		public static bool BuildFromRecordText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, [Optional] DynamicsSetup.ImportSettings importSettings, [Optional] IEnumerable<string> requiredBones)
		{
			return default(bool);
		}

		// Token: 0x06004D5D RID: 19805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E6")]
		[Address(RVA = "0x2127B50", Offset = "0x2127C51", VA = "0x2127B50")]
		public static DynamicsSetup.ParseResults ParseFromRecordText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, [Optional] DynamicsSetup.ImportSettings importSettings)
		{
			return null;
		}

		// Token: 0x06004D5E RID: 19806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E7")]
		[Address(RVA = "0x2127CB0", Offset = "0x2127DB1", VA = "0x2127CB0")]
		public void Build([Optional] IEnumerable<string> requiredBones)
		{
		}

		// Token: 0x06004D5F RID: 19807 RVA: 0x00018AB0 File Offset: 0x00016CB0
		[Token(Token = "0x60040E8")]
		[Address(RVA = "0x21288A0", Offset = "0x21289A1", VA = "0x21288A0")]
		public static int GetVersionFromSetupRecords(List<TextRecordParsing.Record> sourceRecords, out TextRecordParsing.Record versionRecord)
		{
			return 0;
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E9")]
		[Address(RVA = "0x21289F0", Offset = "0x2128AF1", VA = "0x21289F0")]
		public static object SerializeObjectFromStrings(Type type, IEnumerable<string> sourceItems, string firstOptionalField, ref DynamicsSetup.ParseMessage error)
		{
			return null;
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040EA")]
		public static T SerializeObjectFromStrings<T>(IEnumerable<string> sourceItems, string firstOptionalField, ref DynamicsSetup.ParseMessage error) where T : class
		{
			return null;
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x00018AC8 File Offset: 0x00016CC8
		[Token(Token = "0x60040EB")]
		[Address(RVA = "0x2128C90", Offset = "0x2128D91", VA = "0x2128C90")]
		private static int GetVersionFromSetupRecords(List<TextRecordParsing.Record> sourceRecords)
		{
			return 0;
		}

		// Token: 0x06004D63 RID: 19811 RVA: 0x00018AE0 File Offset: 0x00016CE0
		[Token(Token = "0x60040EC")]
		[Address(RVA = "0x2128CC0", Offset = "0x2128DC1", VA = "0x2128CC0")]
		private static bool VerifyVersionAndDetectContents(string recordText, DynamicsSetup.ImportSettings importSettings, out string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x06004D64 RID: 19812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040ED")]
		[Address(RVA = "0x2127D30", Offset = "0x2127E31", VA = "0x2127D30")]
		private static DynamicsSetup.ParseResults InternalParseFromRecordText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, DynamicsSetup.ImportSettings importSettings)
		{
			return null;
		}

		// Token: 0x06004D65 RID: 19813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040EE")]
		[Address(RVA = "0x2129A50", Offset = "0x2129B51", VA = "0x2129A50")]
		public DynamicsSetup()
		{
		}

		// Token: 0x0400AEEC RID: 44780
		[Token(Token = "0x40083F9")]
		private const int UnknownVersion = -1;

		// Token: 0x0400AEED RID: 44781
		[Token(Token = "0x40083FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DynamicsSetup.ImportSettings importSettings;

		// Token: 0x0400AEEE RID: 44782
		[Token(Token = "0x40083FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private GameObject springBoneRoot;

		// Token: 0x0400AEEF RID: 44783
		[Token(Token = "0x40083FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject colliderRoot;

		// Token: 0x0400AEF0 RID: 44784
		[Token(Token = "0x40083FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private SpringBoneSerialization.ParsedSpringBoneSetup springBoneSetup;

		// Token: 0x0400AEF1 RID: 44785
		[Token(Token = "0x40083FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SpringColliderSerialization.ParsedColliderSetup colliderSetup;

		// Token: 0x02000BD9 RID: 3033
		[Token(Token = "0x2001375")]
		public class ImportSettings
		{
			// Token: 0x06004D66 RID: 19814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007759")]
			[Address(RVA = "0x2128F40", Offset = "0x2129041", VA = "0x2128F40")]
			public ImportSettings()
			{
			}

			// Token: 0x06004D67 RID: 19815 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600775A")]
			[Address(RVA = "0x2128F70", Offset = "0x2129071", VA = "0x2128F70")]
			public ImportSettings(DynamicsSetup.ImportSettings sourceSettings)
			{
			}

			// Token: 0x17000A0A RID: 2570
			// (get) Token: 0x06004D68 RID: 19816 RVA: 0x00018AF8 File Offset: 0x00016CF8
			// (set) Token: 0x06004D69 RID: 19817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DCB")]
			public bool ImportSpringBones
			{
				[Token(Token = "0x600775B")]
				[Address(RVA = "0x2129BF0", Offset = "0x2129CF1", VA = "0x2129BF0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B45C0", Offset = "0x1B46C1")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600775C")]
				[Address(RVA = "0x2129C00", Offset = "0x2129D01", VA = "0x2129C00")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B45D0", Offset = "0x1B46D1")]
				set
				{
				}
			}

			// Token: 0x17000A0B RID: 2571
			// (get) Token: 0x06004D6A RID: 19818 RVA: 0x00018B10 File Offset: 0x00016D10
			// (set) Token: 0x06004D6B RID: 19819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DCC")]
			public bool ImportCollision
			{
				[Token(Token = "0x600775D")]
				[Address(RVA = "0x2129C10", Offset = "0x2129D11", VA = "0x2129C10")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B45E0", Offset = "0x1B46E1")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600775E")]
				[Address(RVA = "0x2129C20", Offset = "0x2129D21", VA = "0x2129C20")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B45F0", Offset = "0x1B46F1")]
				set
				{
				}
			}

			// Token: 0x0400AEF2 RID: 44786
			[Token(Token = "0x401B74C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195810", Offset = "0x195911")]
			private bool <ImportSpringBones>k__BackingField;

			// Token: 0x0400AEF3 RID: 44787
			[Token(Token = "0x401B74D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195820", Offset = "0x195921")]
			private bool <ImportCollision>k__BackingField;
		}

		// Token: 0x02000BDA RID: 3034
		[Token(Token = "0x2001376")]
		public class ParseMessage
		{
			// Token: 0x06004D6C RID: 19820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600775F")]
			[Address(RVA = "0x2129120", Offset = "0x2129221", VA = "0x2129120")]
			public ParseMessage(string message, string sourceLine = "", string exception = "", [Optional] UnityEngine.Object context)
			{
			}

			// Token: 0x06004D6D RID: 19821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007760")]
			[Address(RVA = "0x2128B90", Offset = "0x2128C91", VA = "0x2128B90")]
			public ParseMessage(string message, IEnumerable<string> sourceLineItems, string exception = "", [Optional] UnityEngine.Object context)
			{
			}

			// Token: 0x17000A0C RID: 2572
			// (get) Token: 0x06004D6E RID: 19822 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004D6F RID: 19823 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DCD")]
			public string Message
			{
				[Token(Token = "0x6007761")]
				[Address(RVA = "0x2129C30", Offset = "0x2129D31", VA = "0x2129C30")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4600", Offset = "0x1B4701")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007762")]
				[Address(RVA = "0x2129C40", Offset = "0x2129D41", VA = "0x2129C40")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4610", Offset = "0x1B4711")]
				private set
				{
				}
			}

			// Token: 0x17000A0D RID: 2573
			// (get) Token: 0x06004D70 RID: 19824 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004D71 RID: 19825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DCE")]
			public string SourceLine
			{
				[Token(Token = "0x6007763")]
				[Address(RVA = "0x2129C50", Offset = "0x2129D51", VA = "0x2129C50")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4620", Offset = "0x1B4721")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007764")]
				[Address(RVA = "0x2129C60", Offset = "0x2129D61", VA = "0x2129C60")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4630", Offset = "0x1B4731")]
				private set
				{
				}
			}

			// Token: 0x17000A0E RID: 2574
			// (get) Token: 0x06004D72 RID: 19826 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004D73 RID: 19827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DCF")]
			public string Exception
			{
				[Token(Token = "0x6007765")]
				[Address(RVA = "0x2129C70", Offset = "0x2129D71", VA = "0x2129C70")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4640", Offset = "0x1B4741")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007766")]
				[Address(RVA = "0x2129C80", Offset = "0x2129D81", VA = "0x2129C80")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4650", Offset = "0x1B4751")]
				private set
				{
				}
			}

			// Token: 0x17000A0F RID: 2575
			// (get) Token: 0x06004D74 RID: 19828 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004D75 RID: 19829 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DD0")]
			public UnityEngine.Object Context
			{
				[Token(Token = "0x6007767")]
				[Address(RVA = "0x2129C90", Offset = "0x2129D91", VA = "0x2129C90")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4660", Offset = "0x1B4761")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007768")]
				[Address(RVA = "0x2129CA0", Offset = "0x2129DA1", VA = "0x2129CA0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4670", Offset = "0x1B4771")]
				private set
				{
				}
			}

			// Token: 0x06004D76 RID: 19830 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007769")]
			[Address(RVA = "0x2129CB0", Offset = "0x2129DB1", VA = "0x2129CB0")]
			public string ToLogMessage()
			{
				return null;
			}

			// Token: 0x0400AEF4 RID: 44788
			[Token(Token = "0x401B74E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195830", Offset = "0x195931")]
			private string <Message>k__BackingField;

			// Token: 0x0400AEF5 RID: 44789
			[Token(Token = "0x401B74F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195840", Offset = "0x195941")]
			private string <SourceLine>k__BackingField;

			// Token: 0x0400AEF6 RID: 44790
			[Token(Token = "0x401B750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195850", Offset = "0x195951")]
			private string <Exception>k__BackingField;

			// Token: 0x0400AEF7 RID: 44791
			[Token(Token = "0x401B751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195860", Offset = "0x195961")]
			private UnityEngine.Object <Context>k__BackingField;
		}

		// Token: 0x02000BDB RID: 3035
		[Token(Token = "0x2001377")]
		public class ParseResults
		{
			// Token: 0x06004D77 RID: 19831 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600776A")]
			[Address(RVA = "0x2128EB0", Offset = "0x2128FB1", VA = "0x2128EB0")]
			public ParseResults()
			{
			}

			// Token: 0x06004D78 RID: 19832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600776B")]
			[Address(RVA = "0x2129A60", Offset = "0x2129B61", VA = "0x2129A60")]
			public ParseResults(DynamicsSetup setup, IEnumerable<DynamicsSetup.ParseMessage> errors)
			{
			}

			// Token: 0x06004D79 RID: 19833 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600776C")]
			[Address(RVA = "0x2128FB0", Offset = "0x21290B1", VA = "0x2128FB0")]
			public static DynamicsSetup.ParseResults Failure(string error)
			{
				return null;
			}

			// Token: 0x06004D7A RID: 19834 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600776D")]
			[Address(RVA = "0x21291A0", Offset = "0x21292A1", VA = "0x21291A0")]
			public static DynamicsSetup.ParseResults Failure(IEnumerable<DynamicsSetup.ParseMessage> errors)
			{
				return null;
			}

			// Token: 0x17000A10 RID: 2576
			// (get) Token: 0x06004D7B RID: 19835 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004D7C RID: 19836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DD1")]
			public DynamicsSetup Setup
			{
				[Token(Token = "0x600776E")]
				[Address(RVA = "0x2129D80", Offset = "0x2129E81", VA = "0x2129D80")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4680", Offset = "0x1B4781")]
				get
				{
					return null;
				}
				[Token(Token = "0x600776F")]
				[Address(RVA = "0x2129D90", Offset = "0x2129E91", VA = "0x2129D90")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4690", Offset = "0x1B4791")]
				private set
				{
				}
			}

			// Token: 0x17000A11 RID: 2577
			// (get) Token: 0x06004D7D RID: 19837 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004D7E RID: 19838 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DD2")]
			public List<DynamicsSetup.ParseMessage> Errors
			{
				[Token(Token = "0x6007770")]
				[Address(RVA = "0x2129DA0", Offset = "0x2129EA1", VA = "0x2129DA0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B46A0", Offset = "0x1B47A1")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007771")]
				[Address(RVA = "0x2129DB0", Offset = "0x2129EB1", VA = "0x2129DB0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B46B0", Offset = "0x1B47B1")]
				private set
				{
				}
			}

			// Token: 0x17000A12 RID: 2578
			// (get) Token: 0x06004D7F RID: 19839 RVA: 0x00018B28 File Offset: 0x00016D28
			[Token(Token = "0x17000DD3")]
			public bool HasErrors
			{
				[Token(Token = "0x6007772")]
				[Address(RVA = "0x2129DC0", Offset = "0x2129EC1", VA = "0x2129DC0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06004D80 RID: 19840 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007773")]
			[Address(RVA = "0x21280F0", Offset = "0x21281F1", VA = "0x21280F0")]
			public void LogErrors()
			{
			}

			// Token: 0x0400AEF8 RID: 44792
			[Token(Token = "0x401B752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195870", Offset = "0x195971")]
			private DynamicsSetup <Setup>k__BackingField;

			// Token: 0x0400AEF9 RID: 44793
			[Token(Token = "0x401B753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195880", Offset = "0x195981")]
			private List<DynamicsSetup.ParseMessage> <Errors>k__BackingField;
		}

		// Token: 0x02000BDC RID: 3036
		[Token(Token = "0x2001378")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1594C0", Offset = "0x1595C1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004D82 RID: 19842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007775")]
			[Address(RVA = "0x2129B60", Offset = "0x2129C61", VA = "0x2129B60")]
			public <>c()
			{
			}

			// Token: 0x06004D83 RID: 19843 RVA: 0x00018B40 File Offset: 0x00016D40
			[Token(Token = "0x6007776")]
			[Address(RVA = "0x2129B70", Offset = "0x2129C71", VA = "0x2129B70")]
			internal bool <GetVersionFromSetupRecords>b__6_0(TextRecordParsing.Record item)
			{
				return default(bool);
			}

			// Token: 0x0400AEFA RID: 44794
			[Token(Token = "0x401B754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly DynamicsSetup.<>c <>9;

			// Token: 0x0400AEFB RID: 44795
			[Token(Token = "0x401B755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<TextRecordParsing.Record, bool> <>9__6_0;
		}
	}
}
