using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BDD RID: 3037
	[Token(Token = "0x20007E4")]
	public static class SpringBoneSerialization
	{
		// Token: 0x06004D84 RID: 19844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040EF")]
		[Address(RVA = "0x212F700", Offset = "0x212F801", VA = "0x212F700")]
		public static string BuildDynamicsSetupString(GameObject rootObject, [Optional] SpringBoneSerialization.ExportSettings exportSettings)
		{
			return null;
		}

		// Token: 0x06004D85 RID: 19845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F0")]
		[Address(RVA = "0x212F970", Offset = "0x212FA71", VA = "0x212F970")]
		private static SpringBoneSerialization.AngleLimitSerializer AngleLimitsToSerializer(AngleLimits sourceLimits)
		{
			return null;
		}

		// Token: 0x06004D86 RID: 19846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F1")]
		[Address(RVA = "0x212FA10", Offset = "0x212FB11", VA = "0x212FA10")]
		private static SpringBoneSerialization.SpringBoneBaseSerializer SpringBoneToBaseSerializer(SpringBone sourceBone)
		{
			return null;
		}

		// Token: 0x06004D87 RID: 19847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x212FDD0", Offset = "0x212FED1", VA = "0x212FDD0")]
		private static SpringBoneSerialization.PivotSerializer PivotToSerializer(Transform sourcePivot)
		{
			return null;
		}

		// Token: 0x06004D88 RID: 19848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F3")]
		[Address(RVA = "0x212FEF0", Offset = "0x212FFF1", VA = "0x212FEF0")]
		private static void AppendSpringBones(CSVBuilder builder, IEnumerable<SpringBone> springBones)
		{
		}

		// Token: 0x06004D89 RID: 19849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F4")]
		[Address(RVA = "0x2130FD0", Offset = "0x21310D1", VA = "0x2130FD0")]
		private static void AppendPivots(CSVBuilder builder, IEnumerable<SpringBone> springBones)
		{
		}

		// Token: 0x06004D8A RID: 19850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F5")]
		[Address(RVA = "0x212F850", Offset = "0x212F951", VA = "0x212F850")]
		private static string BuildSpringBoneSetupString(GameObject rootObject)
		{
			return null;
		}

		// Token: 0x06004D8B RID: 19851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F6")]
		[Address(RVA = "0x21317D0", Offset = "0x21318D1", VA = "0x21317D0")]
		private static IEnumerable<SpringBoneSerialization.PivotSerializer> SerializePivotRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords)
		{
			return null;
		}

		// Token: 0x06004D8C RID: 19852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F7")]
		[Address(RVA = "0x2131C70", Offset = "0x2131D71", VA = "0x2131C70")]
		private static IEnumerable<SpringBoneSerialization.SpringBoneSerializer> SerializeSpringBoneRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords)
		{
			return null;
		}

		// Token: 0x06004D8D RID: 19853 RVA: 0x00018B58 File Offset: 0x00016D58
		[Token(Token = "0x60040F8")]
		[Address(RVA = "0x21322B0", Offset = "0x21323B1", VA = "0x21322B0")]
		private static bool VerifyPivotRecords(IEnumerable<SpringBoneSerialization.PivotSerializer> sourceRecords, IEnumerable<string> validParentNames, List<SpringBoneSerialization.PivotSerializer> validRecords, List<DynamicsSetup.ParseMessage> errors)
		{
			return default(bool);
		}

		// Token: 0x06004D8E RID: 19854 RVA: 0x00018B70 File Offset: 0x00016D70
		[Token(Token = "0x60040F9")]
		[Address(RVA = "0x21328B0", Offset = "0x21329B1", VA = "0x21328B0")]
		private static bool VerifySpringBoneRecords(IEnumerable<SpringBoneSerialization.SpringBoneSerializer> sourceRecords, IEnumerable<string> validBoneNames, IEnumerable<string> validPivotNames, IEnumerable<string> validColliderNames, List<SpringBoneSerialization.SpringBoneSerializer> validRecords, out bool hasMissingColliders, List<DynamicsSetup.ParseMessage> errors)
		{
			return default(bool);
		}

		// Token: 0x06004D8F RID: 19855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040FA")]
		[Address(RVA = "0x2133100", Offset = "0x2133201", VA = "0x2133100")]
		private static AngleLimits BuildAngleLimitsFromSerializer(SpringBoneSerialization.AngleLimitSerializer serializer)
		{
			return null;
		}

		// Token: 0x06004D90 RID: 19856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040FB")]
		[Address(RVA = "0x2133190", Offset = "0x2133291", VA = "0x2133190")]
		private static Transform FindChildByName(Transform parent, string name)
		{
			return null;
		}

		// Token: 0x06004D91 RID: 19857 RVA: 0x00018B88 File Offset: 0x00016D88
		[Token(Token = "0x60040FC")]
		[Address(RVA = "0x2133290", Offset = "0x2133391", VA = "0x2133290")]
		private static bool BuildPivotFromSerializer(Dictionary<string, Transform> transforms, SpringBoneSerialization.PivotSerializer serializer)
		{
			return default(bool);
		}

		// Token: 0x06004D92 RID: 19858 RVA: 0x00018BA0 File Offset: 0x00016DA0
		[Token(Token = "0x60040FD")]
		[Address(RVA = "0x21334B0", Offset = "0x21335B1", VA = "0x21334B0")]
		private static bool BuildSpringBoneFromSerializer(SpringBoneSerialization.SpringBoneSetupMaps setupMaps, SpringBoneSerialization.SpringBoneSerializer serializer)
		{
			return default(bool);
		}

		// Token: 0x02000BDE RID: 3038
		[Token(Token = "0x2001379")]
		public class ExportSettings
		{
			// Token: 0x06004D93 RID: 19859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007777")]
			[Address(RVA = "0x212F820", Offset = "0x212F921", VA = "0x212F820")]
			public ExportSettings()
			{
			}

			// Token: 0x17000A13 RID: 2579
			// (get) Token: 0x06004D94 RID: 19860 RVA: 0x00018BB8 File Offset: 0x00016DB8
			// (set) Token: 0x06004D95 RID: 19861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DD4")]
			public bool ExportSpringBones
			{
				[Token(Token = "0x6007778")]
				[Address(RVA = "0x21344A0", Offset = "0x21345A1", VA = "0x21344A0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B46C0", Offset = "0x1B47C1")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6007779")]
				[Address(RVA = "0x21344B0", Offset = "0x21345B1", VA = "0x21344B0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B46D0", Offset = "0x1B47D1")]
				set
				{
				}
			}

			// Token: 0x17000A14 RID: 2580
			// (get) Token: 0x06004D96 RID: 19862 RVA: 0x00018BD0 File Offset: 0x00016DD0
			// (set) Token: 0x06004D97 RID: 19863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DD5")]
			public bool ExportCollision
			{
				[Token(Token = "0x600777A")]
				[Address(RVA = "0x21344C0", Offset = "0x21345C1", VA = "0x21344C0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B46E0", Offset = "0x1B47E1")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600777B")]
				[Address(RVA = "0x21344D0", Offset = "0x21345D1", VA = "0x21344D0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B46F0", Offset = "0x1B47F1")]
				set
				{
				}
			}

			// Token: 0x0400AEFC RID: 44796
			[Token(Token = "0x401B756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x195890", Offset = "0x195991")]
			private bool <ExportSpringBones>k__BackingField;

			// Token: 0x0400AEFD RID: 44797
			[Token(Token = "0x401B757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1958A0", Offset = "0x1959A1")]
			private bool <ExportCollision>k__BackingField;
		}

		// Token: 0x02000BDF RID: 3039
		[Token(Token = "0x200137A")]
		public class ParsedSpringBoneSetup
		{
			// Token: 0x17000A15 RID: 2581
			// (get) Token: 0x06004D98 RID: 19864 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004D99 RID: 19865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DD6")]
			public IEnumerable<DynamicsSetup.ParseMessage> Errors
			{
				[Token(Token = "0x600777C")]
				[Address(RVA = "0x21344E0", Offset = "0x21345E1", VA = "0x21344E0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4700", Offset = "0x1B4801")]
				get
				{
					return null;
				}
				[Token(Token = "0x600777D")]
				[Address(RVA = "0x21344F0", Offset = "0x21345F1", VA = "0x21344F0")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4710", Offset = "0x1B4811")]
				set
				{
				}
			}

			// Token: 0x06004D9A RID: 19866 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600777E")]
			[Address(RVA = "0x2129270", Offset = "0x2129371", VA = "0x2129270")]
			public static SpringBoneSerialization.ParsedSpringBoneSetup ReadSpringBoneSetupFromText(GameObject springBoneRoot, GameObject colliderRoot, string recordText, IEnumerable<string> inputValidColliderNames)
			{
				return null;
			}

			// Token: 0x06004D9B RID: 19867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600777F")]
			[Address(RVA = "0x21282E0", Offset = "0x21283E1", VA = "0x21282E0")]
			public void BuildObjects(GameObject springBoneRoot, GameObject colliderRoot, IEnumerable<string> requiredBones)
			{
			}

			// Token: 0x06004D9C RID: 19868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007780")]
			[Address(RVA = "0x2134510", Offset = "0x2134611", VA = "0x2134510")]
			private void FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones(GameObject springBoneRoot, IEnumerable<string> requiredBones)
			{
			}

			// Token: 0x06004D9D RID: 19869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007781")]
			[Address(RVA = "0x2134500", Offset = "0x2134601", VA = "0x2134500")]
			public ParsedSpringBoneSetup()
			{
			}

			// Token: 0x0400AEFE RID: 44798
			[Token(Token = "0x401B758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1958B0", Offset = "0x1959B1")]
			private IEnumerable<DynamicsSetup.ParseMessage> <Errors>k__BackingField;

			// Token: 0x0400AEFF RID: 44799
			[Token(Token = "0x401B759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private IEnumerable<SpringBoneSerialization.PivotSerializer> pivotRecords;

			// Token: 0x0400AF00 RID: 44800
			[Token(Token = "0x401B75A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private IEnumerable<SpringBoneSerialization.SpringBoneSerializer> springBoneRecords;

			// Token: 0x02000BE0 RID: 3040
			[Token(Token = "0x2001653")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AE00", Offset = "0x15AF01")]
			private sealed class <>c__DisplayClass4_0
			{
				// Token: 0x06004D9E RID: 19870 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080A5")]
				[Address(RVA = "0x23A5770", Offset = "0x23A5871", VA = "0x23A5770")]
				public <>c__DisplayClass4_0()
				{
				}

				// Token: 0x06004D9F RID: 19871 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080A6")]
				[Address(RVA = "0x23A5780", Offset = "0x23A5881", VA = "0x23A5780")]
				internal IEnumerable<Component> <ReadSpringBoneSetupFromText>b__2(Type type)
				{
					return null;
				}

				// Token: 0x0400AF01 RID: 44801
				[Token(Token = "0x401C40A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public GameObject colliderRoot;
			}

			// Token: 0x02000BE1 RID: 3041
			[Token(Token = "0x2001654")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AE10", Offset = "0x15AF11")]
			private sealed class <>c__DisplayClass4_1
			{
				// Token: 0x06004DA0 RID: 19872 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080A7")]
				[Address(RVA = "0x23A57A0", Offset = "0x23A58A1", VA = "0x23A57A0")]
				public <>c__DisplayClass4_1()
				{
				}

				// Token: 0x06004DA1 RID: 19873 RVA: 0x00018BE8 File Offset: 0x00016DE8
				[Token(Token = "0x60080A8")]
				[Address(RVA = "0x23A57B0", Offset = "0x23A58B1", VA = "0x23A57B0")]
				internal bool <ReadSpringBoneSetupFromText>b__4(TextRecordParsing.Record item)
				{
					return default(bool);
				}

				// Token: 0x0400AF02 RID: 44802
				[Token(Token = "0x401C40B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public TextRecordParsing.Record versionRecord;
			}

			// Token: 0x02000BE2 RID: 3042
			[Token(Token = "0x2001655")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AE20", Offset = "0x15AF21")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06004DA3 RID: 19875 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080AA")]
				[Address(RVA = "0x23A5640", Offset = "0x23A5741", VA = "0x23A5640")]
				public <>c()
				{
				}

				// Token: 0x06004DA4 RID: 19876 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080AB")]
				[Address(RVA = "0x23A5650", Offset = "0x23A5751", VA = "0x23A5650")]
				internal string <ReadSpringBoneSetupFromText>b__4_0(Transform item)
				{
					return null;
				}

				// Token: 0x06004DA5 RID: 19877 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080AC")]
				[Address(RVA = "0x23A5670", Offset = "0x23A5771", VA = "0x23A5670")]
				internal string <ReadSpringBoneSetupFromText>b__4_1(SpringBoneSerialization.PivotSerializer record)
				{
					return null;
				}

				// Token: 0x06004DA6 RID: 19878 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080AD")]
				[Address(RVA = "0x23A5690", Offset = "0x23A5791", VA = "0x23A5690")]
				internal string <ReadSpringBoneSetupFromText>b__4_3(Component item)
				{
					return null;
				}

				// Token: 0x06004DA7 RID: 19879 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080AE")]
				[Address(RVA = "0x23A56B0", Offset = "0x23A57B1", VA = "0x23A56B0")]
				internal string <FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones>b__8_1(SpringBoneSerialization.SpringBoneSerializer record)
				{
					return null;
				}

				// Token: 0x06004DA8 RID: 19880 RVA: 0x00018C00 File Offset: 0x00016E00
				[Token(Token = "0x60080AF")]
				[Address(RVA = "0x23A56E0", Offset = "0x23A57E1", VA = "0x23A56E0")]
				internal bool <FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones>b__8_3(Transform item)
				{
					return default(bool);
				}

				// Token: 0x06004DA9 RID: 19881 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080B0")]
				[Address(RVA = "0x23A5750", Offset = "0x23A5851", VA = "0x23A5750")]
				internal GameObject <FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones>b__8_4(Transform item)
				{
					return null;
				}

				// Token: 0x0400AF03 RID: 44803
				[Token(Token = "0x401C40C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly SpringBoneSerialization.ParsedSpringBoneSetup.<>c <>9;

				// Token: 0x0400AF04 RID: 44804
				[Token(Token = "0x401C40D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static Func<Transform, string> <>9__4_0;

				// Token: 0x0400AF05 RID: 44805
				[Token(Token = "0x401C40E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public static Func<SpringBoneSerialization.PivotSerializer, string> <>9__4_1;

				// Token: 0x0400AF06 RID: 44806
				[Token(Token = "0x401C40F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public static Func<Component, string> <>9__4_3;

				// Token: 0x0400AF07 RID: 44807
				[Token(Token = "0x401C410")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public static Func<SpringBoneSerialization.SpringBoneSerializer, string> <>9__8_1;

				// Token: 0x0400AF08 RID: 44808
				[Token(Token = "0x401C411")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public static Func<Transform, bool> <>9__8_3;

				// Token: 0x0400AF09 RID: 44809
				[Token(Token = "0x401C412")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public static Func<Transform, GameObject> <>9__8_4;
			}

			// Token: 0x02000BE3 RID: 3043
			[Token(Token = "0x2001656")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AE30", Offset = "0x15AF31")]
			private sealed class <>c__DisplayClass8_0
			{
				// Token: 0x06004DAA RID: 19882 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080B1")]
				[Address(RVA = "0x23A57C0", Offset = "0x23A58C1", VA = "0x23A57C0")]
				public <>c__DisplayClass8_0()
				{
				}

				// Token: 0x06004DAB RID: 19883 RVA: 0x00018C18 File Offset: 0x00016E18
				[Token(Token = "0x60080B2")]
				[Address(RVA = "0x23A57D0", Offset = "0x23A58D1", VA = "0x23A57D0")]
				internal bool <FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones>b__0(SpringBoneSerialization.SpringBoneSerializer record)
				{
					return default(bool);
				}

				// Token: 0x06004DAC RID: 19884 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080B3")]
				[Address(RVA = "0x23A5840", Offset = "0x23A5941", VA = "0x23A5840")]
				internal Transform <FilterBoneRecordsByRequiredBonesAndCreateUnrecordedBones>b__2(string boneName)
				{
					return null;
				}

				// Token: 0x0400AF0A RID: 44810
				[Token(Token = "0x401C413")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public IEnumerable<string> requiredBones;

				// Token: 0x0400AF0B RID: 44811
				[Token(Token = "0x401C414")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public GameObject springBoneRoot;
			}
		}

		// Token: 0x02000BE4 RID: 3044
		[Token(Token = "0x200137B")]
		private class PersistentSpringManagerProperties
		{
			// Token: 0x06004DAD RID: 19885 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007782")]
			[Address(RVA = "0x23A5850", Offset = "0x23A5951", VA = "0x23A5850")]
			public static SpringBoneSerialization.PersistentSpringManagerProperties Create(SpringManager sourceManager)
			{
				return null;
			}

			// Token: 0x06004DAE RID: 19886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007783")]
			[Address(RVA = "0x23A5950", Offset = "0x23A5A51", VA = "0x23A5950")]
			public void ApplyTo(SpringManager targetManager)
			{
			}

			// Token: 0x06004DAF RID: 19887 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007784")]
			[Address(RVA = "0x23A5940", Offset = "0x23A5A41", VA = "0x23A5940")]
			public PersistentSpringManagerProperties()
			{
			}

			// Token: 0x0400AF0C RID: 44812
			[Token(Token = "0x401B75B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool automaticUpdates;

			// Token: 0x0400AF0D RID: 44813
			[Token(Token = "0x401B75C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private int simulationFrameRate;

			// Token: 0x0400AF0E RID: 44814
			[Token(Token = "0x401B75D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float dynamicRatio;

			// Token: 0x0400AF0F RID: 44815
			[Token(Token = "0x401B75E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Vector3 gravity;

			// Token: 0x0400AF10 RID: 44816
			[Token(Token = "0x401B75F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool collideWithGround;

			// Token: 0x0400AF11 RID: 44817
			[Token(Token = "0x401B760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float groundHeight;

			// Token: 0x0400AF12 RID: 44818
			[Token(Token = "0x401B761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float bounce;

			// Token: 0x0400AF13 RID: 44819
			[Token(Token = "0x401B762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float friction;
		}

		// Token: 0x02000BE5 RID: 3045
		[Token(Token = "0x200137C")]
		private class SpringBoneSetupMaps
		{
			// Token: 0x06004DB0 RID: 19888 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007785")]
			[Address(RVA = "0x23A59E0", Offset = "0x23A5AE1", VA = "0x23A59E0")]
			public static SpringBoneSerialization.SpringBoneSetupMaps Build(GameObject springBoneRoot, GameObject colliderRoot)
			{
				return null;
			}

			// Token: 0x06004DB1 RID: 19889 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007786")]
			[Address(RVA = "0x23A5B00", Offset = "0x23A5C01", VA = "0x23A5B00")]
			public SpringBoneSetupMaps()
			{
			}

			// Token: 0x0400AF14 RID: 44820
			[Token(Token = "0x401B763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<string, Transform> allChildren;

			// Token: 0x0400AF15 RID: 44821
			[Token(Token = "0x401B764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<string, SpringSphereCollider> sphereColliders;

			// Token: 0x0400AF16 RID: 44822
			[Token(Token = "0x401B765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<string, SpringCapsuleCollider> capsuleColliders;

			// Token: 0x0400AF17 RID: 44823
			[Token(Token = "0x401B766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Dictionary<string, SpringPanelCollider> panelColliders;
		}

		// Token: 0x02000BE6 RID: 3046
		[Token(Token = "0x200137D")]
		private class PivotSerializer
		{
			// Token: 0x06004DB2 RID: 19890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007787")]
			[Address(RVA = "0x23A59B0", Offset = "0x23A5AB1", VA = "0x23A59B0")]
			public PivotSerializer()
			{
			}

			// Token: 0x0400AF18 RID: 44824
			[Token(Token = "0x401B767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0400AF19 RID: 44825
			[Token(Token = "0x401B768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string parentName;

			// Token: 0x0400AF1A RID: 44826
			[Token(Token = "0x401B769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 eulerAngles;
		}

		// Token: 0x02000BE7 RID: 3047
		[Token(Token = "0x200137E")]
		private class AngleLimitSerializer
		{
			// Token: 0x06004DB3 RID: 19891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007788")]
			[Address(RVA = "0x212FA00", Offset = "0x212FB01", VA = "0x212FA00")]
			public AngleLimitSerializer()
			{
			}

			// Token: 0x0400AF1B RID: 44827
			[Token(Token = "0x401B76A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			// Token: 0x0400AF1C RID: 44828
			[Token(Token = "0x401B76B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float min;

			// Token: 0x0400AF1D RID: 44829
			[Token(Token = "0x401B76C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float max;
		}

		// Token: 0x02000BE8 RID: 3048
		[Token(Token = "0x200137F")]
		private class LengthLimitSerializer
		{
			// Token: 0x06004DB4 RID: 19892 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007789")]
			[Address(RVA = "0x2133D60", Offset = "0x2133E61", VA = "0x2133D60")]
			public LengthLimitSerializer()
			{
			}

			// Token: 0x0400AF1E RID: 44830
			[Token(Token = "0x401B76D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string objectName;

			// Token: 0x0400AF1F RID: 44831
			[Token(Token = "0x401B76E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float ratio;
		}

		// Token: 0x02000BE9 RID: 3049
		[Token(Token = "0x2001380")]
		private class SpringBoneBaseSerializer
		{
			// Token: 0x06004DB5 RID: 19893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600778A")]
			[Address(RVA = "0x23A59C0", Offset = "0x23A5AC1", VA = "0x23A59C0")]
			public SpringBoneBaseSerializer()
			{
			}

			// Token: 0x0400AF20 RID: 44832
			[Token(Token = "0x401B76F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string boneName;

			// Token: 0x0400AF21 RID: 44833
			[Token(Token = "0x401B770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float radius;

			// Token: 0x0400AF22 RID: 44834
			[Token(Token = "0x401B771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float stiffness;

			// Token: 0x0400AF23 RID: 44835
			[Token(Token = "0x401B772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float drag;

			// Token: 0x0400AF24 RID: 44836
			[Token(Token = "0x401B773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 springForce;

			// Token: 0x0400AF25 RID: 44837
			[Token(Token = "0x401B774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float windInfluence;

			// Token: 0x0400AF26 RID: 44838
			[Token(Token = "0x401B775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string pivotName;

			// Token: 0x0400AF27 RID: 44839
			[Token(Token = "0x401B776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public SpringBoneSerialization.AngleLimitSerializer yAngleLimits;

			// Token: 0x0400AF28 RID: 44840
			[Token(Token = "0x401B777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public SpringBoneSerialization.AngleLimitSerializer zAngleLimits;

			// Token: 0x0400AF29 RID: 44841
			[Token(Token = "0x401B778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public float angularStiffness;

			// Token: 0x0400AF2A RID: 44842
			[Token(Token = "0x401B779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SpringBoneSerialization.LengthLimitSerializer[] lengthLimits;
		}

		// Token: 0x02000BEA RID: 3050
		[Token(Token = "0x2001381")]
		private class SpringBoneSerializer
		{
			// Token: 0x06004DB6 RID: 19894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600778B")]
			[Address(RVA = "0x23A59D0", Offset = "0x23A5AD1", VA = "0x23A59D0")]
			public SpringBoneSerializer()
			{
			}

			// Token: 0x0400AF2B RID: 44843
			[Token(Token = "0x401B77A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpringBoneSerialization.SpringBoneBaseSerializer baseData;

			// Token: 0x0400AF2C RID: 44844
			[Token(Token = "0x401B77B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string[] colliderNames;
		}

		// Token: 0x02000BEB RID: 3051
		[Token(Token = "0x2001382")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1594D0", Offset = "0x1595D1")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004DB8 RID: 19896 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600778D")]
			[Address(RVA = "0x2133C40", Offset = "0x2133D41", VA = "0x2133C40")]
			public <>c()
			{
			}

			// Token: 0x06004DB9 RID: 19897 RVA: 0x00018C30 File Offset: 0x00016E30
			[Token(Token = "0x600778E")]
			[Address(RVA = "0x2133C50", Offset = "0x2133D51", VA = "0x2133C50")]
			internal bool <SpringBoneToBaseSerializer>b__3_0(Transform item)
			{
				return default(bool);
			}

			// Token: 0x06004DBA RID: 19898 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600778F")]
			[Address(RVA = "0x2133CC0", Offset = "0x2133DC1", VA = "0x2133CC0")]
			internal SpringBoneSerialization.LengthLimitSerializer <SpringBoneToBaseSerializer>b__3_1(Transform item)
			{
				return null;
			}

			// Token: 0x06004DBB RID: 19899 RVA: 0x00018C48 File Offset: 0x00016E48
			[Token(Token = "0x6007790")]
			[Address(RVA = "0x2133D70", Offset = "0x2133E71", VA = "0x2133D70")]
			internal bool <AppendSpringBones>b__5_0(SpringSphereCollider item)
			{
				return default(bool);
			}

			// Token: 0x06004DBC RID: 19900 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007791")]
			[Address(RVA = "0x2133DE0", Offset = "0x2133EE1", VA = "0x2133DE0")]
			internal string <AppendSpringBones>b__5_1(SpringSphereCollider item)
			{
				return null;
			}

			// Token: 0x06004DBD RID: 19901 RVA: 0x00018C60 File Offset: 0x00016E60
			[Token(Token = "0x6007792")]
			[Address(RVA = "0x2133E00", Offset = "0x2133F01", VA = "0x2133E00")]
			internal bool <AppendSpringBones>b__5_2(SpringCapsuleCollider item)
			{
				return default(bool);
			}

			// Token: 0x06004DBE RID: 19902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007793")]
			[Address(RVA = "0x2133E70", Offset = "0x2133F71", VA = "0x2133E70")]
			internal string <AppendSpringBones>b__5_3(SpringCapsuleCollider item)
			{
				return null;
			}

			// Token: 0x06004DBF RID: 19903 RVA: 0x00018C78 File Offset: 0x00016E78
			[Token(Token = "0x6007794")]
			[Address(RVA = "0x2133E90", Offset = "0x2133F91", VA = "0x2133E90")]
			internal bool <AppendSpringBones>b__5_4(SpringPanelCollider item)
			{
				return default(bool);
			}

			// Token: 0x06004DC0 RID: 19904 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007795")]
			[Address(RVA = "0x2133F00", Offset = "0x2134001", VA = "0x2133F00")]
			internal string <AppendSpringBones>b__5_5(SpringPanelCollider item)
			{
				return null;
			}

			// Token: 0x06004DC1 RID: 19905 RVA: 0x00018C90 File Offset: 0x00016E90
			[Token(Token = "0x6007796")]
			[Address(RVA = "0x2133F20", Offset = "0x2134021", VA = "0x2133F20")]
			internal bool <AppendPivots>b__6_0(SpringBone bone)
			{
				return default(bool);
			}

			// Token: 0x06004DC2 RID: 19906 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007797")]
			[Address(RVA = "0x2134040", Offset = "0x2134141", VA = "0x2134040")]
			internal Transform <AppendPivots>b__6_1(SpringBone bone)
			{
				return null;
			}

			// Token: 0x06004DC3 RID: 19907 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6007798")]
			[Address(RVA = "0x2134060", Offset = "0x2134161", VA = "0x2134060")]
			internal SpringBoneSerialization.PivotSerializer <AppendPivots>b__6_2(Transform pivot)
			{
				return null;
			}

			// Token: 0x06004DC4 RID: 19908 RVA: 0x00018CA8 File Offset: 0x00016EA8
			[Token(Token = "0x6007799")]
			[Address(RVA = "0x2134070", Offset = "0x2134171", VA = "0x2134070")]
			internal bool <SerializeSpringBoneRecords>b__17_0(string item)
			{
				return default(bool);
			}

			// Token: 0x0400AF2D RID: 44845
			[Token(Token = "0x401B77C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly SpringBoneSerialization.<>c <>9;

			// Token: 0x0400AF2E RID: 44846
			[Token(Token = "0x401B77D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Transform, bool> <>9__3_0;

			// Token: 0x0400AF2F RID: 44847
			[Token(Token = "0x401B77E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Transform, SpringBoneSerialization.LengthLimitSerializer> <>9__3_1;

			// Token: 0x0400AF30 RID: 44848
			[Token(Token = "0x401B77F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<SpringSphereCollider, bool> <>9__5_0;

			// Token: 0x0400AF31 RID: 44849
			[Token(Token = "0x401B780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<SpringSphereCollider, string> <>9__5_1;

			// Token: 0x0400AF32 RID: 44850
			[Token(Token = "0x401B781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<SpringCapsuleCollider, bool> <>9__5_2;

			// Token: 0x0400AF33 RID: 44851
			[Token(Token = "0x401B782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<SpringCapsuleCollider, string> <>9__5_3;

			// Token: 0x0400AF34 RID: 44852
			[Token(Token = "0x401B783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<SpringPanelCollider, bool> <>9__5_4;

			// Token: 0x0400AF35 RID: 44853
			[Token(Token = "0x401B784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<SpringPanelCollider, string> <>9__5_5;

			// Token: 0x0400AF36 RID: 44854
			[Token(Token = "0x401B785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static Func<SpringBone, bool> <>9__6_0;

			// Token: 0x0400AF37 RID: 44855
			[Token(Token = "0x401B786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static Func<SpringBone, Transform> <>9__6_1;

			// Token: 0x0400AF38 RID: 44856
			[Token(Token = "0x401B787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static Func<Transform, SpringBoneSerialization.PivotSerializer> <>9__6_2;

			// Token: 0x0400AF39 RID: 44857
			[Token(Token = "0x401B788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static Func<string, bool> <>9__17_0;
		}

		// Token: 0x02000BEC RID: 3052
		[Token(Token = "0x2001383")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1594E0", Offset = "0x1595E1")]
		private sealed class <>c__DisplayClass19_0
		{
			// Token: 0x06004DC5 RID: 19909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600779A")]
			[Address(RVA = "0x21330F0", Offset = "0x21331F1", VA = "0x21330F0")]
			public <>c__DisplayClass19_0()
			{
			}

			// Token: 0x06004DC6 RID: 19910 RVA: 0x00018CC0 File Offset: 0x00016EC0
			[Token(Token = "0x600779B")]
			[Address(RVA = "0x2134090", Offset = "0x2134191", VA = "0x2134090")]
			internal bool <VerifySpringBoneRecords>b__0(string name)
			{
				return default(bool);
			}

			// Token: 0x0400AF3A RID: 44858
			[Token(Token = "0x401B789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public IEnumerable<string> validColliderNames;

			// Token: 0x0400AF3B RID: 44859
			[Token(Token = "0x401B78A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, bool> <>9__0;
		}

		// Token: 0x02000BED RID: 3053
		[Token(Token = "0x2001384")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1594F0", Offset = "0x1595F1")]
		private sealed class <>c__DisplayClass23_0
		{
			// Token: 0x06004DC7 RID: 19911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600779C")]
			[Address(RVA = "0x2133BC0", Offset = "0x2133CC1", VA = "0x2133BC0")]
			public <>c__DisplayClass23_0()
			{
			}

			// Token: 0x06004DC8 RID: 19912 RVA: 0x00018CD8 File Offset: 0x00016ED8
			[Token(Token = "0x600779D")]
			[Address(RVA = "0x2134100", Offset = "0x2134201", VA = "0x2134100")]
			internal bool <BuildSpringBoneFromSerializer>b__0(SpringBoneSerialization.LengthLimitSerializer lengthLimit)
			{
				return default(bool);
			}

			// Token: 0x06004DC9 RID: 19913 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600779E")]
			[Address(RVA = "0x2134180", Offset = "0x2134281", VA = "0x2134180")]
			internal Transform <BuildSpringBoneFromSerializer>b__1(SpringBoneSerialization.LengthLimitSerializer lengthLimit)
			{
				return null;
			}

			// Token: 0x06004DCA RID: 19914 RVA: 0x00018CF0 File Offset: 0x00016EF0
			[Token(Token = "0x600779F")]
			[Address(RVA = "0x2134200", Offset = "0x2134301", VA = "0x2134200")]
			internal bool <BuildSpringBoneFromSerializer>b__2(string name)
			{
				return default(bool);
			}

			// Token: 0x06004DCB RID: 19915 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077A0")]
			[Address(RVA = "0x2134270", Offset = "0x2134371", VA = "0x2134270")]
			internal SpringSphereCollider <BuildSpringBoneFromSerializer>b__3(string name)
			{
				return null;
			}

			// Token: 0x06004DCC RID: 19916 RVA: 0x00018D08 File Offset: 0x00016F08
			[Token(Token = "0x60077A1")]
			[Address(RVA = "0x21342E0", Offset = "0x21343E1", VA = "0x21342E0")]
			internal bool <BuildSpringBoneFromSerializer>b__4(string name)
			{
				return default(bool);
			}

			// Token: 0x06004DCD RID: 19917 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077A2")]
			[Address(RVA = "0x2134350", Offset = "0x2134451", VA = "0x2134350")]
			internal SpringCapsuleCollider <BuildSpringBoneFromSerializer>b__5(string name)
			{
				return null;
			}

			// Token: 0x06004DCE RID: 19918 RVA: 0x00018D20 File Offset: 0x00016F20
			[Token(Token = "0x60077A3")]
			[Address(RVA = "0x21343C0", Offset = "0x21344C1", VA = "0x21343C0")]
			internal bool <BuildSpringBoneFromSerializer>b__6(string name)
			{
				return default(bool);
			}

			// Token: 0x06004DCF RID: 19919 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077A4")]
			[Address(RVA = "0x2134430", Offset = "0x2134531", VA = "0x2134430")]
			internal SpringPanelCollider <BuildSpringBoneFromSerializer>b__7(string name)
			{
				return null;
			}

			// Token: 0x0400AF3C RID: 44860
			[Token(Token = "0x401B78B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpringBoneSerialization.SpringBoneSetupMaps setupMaps;
		}
	}
}
