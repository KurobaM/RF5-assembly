using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace UTJ
{
	// Token: 0x02000BF2 RID: 3058
	[Token(Token = "0x20007E6")]
	public static class SpringColliderSerialization
	{
		// Token: 0x06004DEC RID: 19948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410C")]
		[Address(RVA = "0x23A90E0", Offset = "0x23A91E1", VA = "0x23A90E0")]
		public static string BuildCollisionSetupString(GameObject colliderRoot)
		{
			return null;
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600410D")]
		[Address(RVA = "0x23A9190", Offset = "0x23A9291", VA = "0x23A9190")]
		private static void AppendColliders(CSVBuilder builder, GameObject colliderRoot)
		{
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410E")]
		[Address(RVA = "0x23AB7F0", Offset = "0x23AB8F1", VA = "0x23AB7F0")]
		private static string GetComponentName(Component component)
		{
			return null;
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410F")]
		[Address(RVA = "0x23AB890", Offset = "0x23AB991", VA = "0x23AB890")]
		private static SpringColliderSerialization.TransformSerializer TransformToSerializer(Transform sourceTransform)
		{
			return null;
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004110")]
		[Address(RVA = "0x23ABA10", Offset = "0x23ABB11", VA = "0x23ABA10")]
		private static SpringColliderSerialization.ColliderSerializerBaseInfo TransformToColliderSerializerBaseInfo(Transform sourceTransform, string colliderType)
		{
			return null;
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004111")]
		[Address(RVA = "0x23ABAC0", Offset = "0x23ABBC1", VA = "0x23ABAC0")]
		private static SpringColliderSerialization.SphereColliderSerializer SphereColliderToSerializer(SpringSphereCollider sourceCollider)
		{
			return null;
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004112")]
		[Address(RVA = "0x23ABC10", Offset = "0x23ABD11", VA = "0x23ABC10")]
		private static SpringColliderSerialization.CapsuleColliderSerializer CapsuleColliderToSerializer(SpringCapsuleCollider sourceCollider)
		{
			return null;
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004113")]
		[Address(RVA = "0x23ABD60", Offset = "0x23ABE61", VA = "0x23ABD60")]
		private static SpringColliderSerialization.PanelColliderSerializer PanelColliderToSerializer(SpringPanelCollider sourceCollider)
		{
			return null;
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004114")]
		[Address(RVA = "0x23AAE90", Offset = "0x23AAF91", VA = "0x23AAE90")]
		private static void AppendDynamicsNulls(CSVBuilder builder, GameObject rootObject)
		{
		}

		// Token: 0x06004DF5 RID: 19957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004115")]
		[Address(RVA = "0x23AB250", Offset = "0x23AB351", VA = "0x23AB250")]
		private static string BuildComponentDefinitionString(GameObject colliderRoot)
		{
			return null;
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004116")]
		private static void AppendRecordItem<T>(StringBuilder builder, T item, char separator = ',')
		{
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004117")]
		[Address(RVA = "0x23AC0F0", Offset = "0x23AC1F1", VA = "0x23AC0F0")]
		private static Transform CreateNewGameObject(Transform parent, string name)
		{
			return null;
		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004118")]
		[Address(RVA = "0x23AC220", Offset = "0x23AC321", VA = "0x23AC220")]
		private static Transform GetChildByName(Transform parent, string name)
		{
			return null;
		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004119")]
		private static T TryToFindComponent<T>(GameObject gameObject, string name) where T : Component
		{
			return null;
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411A")]
		[Address(RVA = "0x23AC390", Offset = "0x23AC491", VA = "0x23AC390")]
		private static IEnumerable<SpringColliderSerialization.IColliderSerializer> SerializeColliderRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords)
		{
			return null;
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411B")]
		[Address(RVA = "0x23AC8F0", Offset = "0x23AC9F1", VA = "0x23AC8F0")]
		private static IEnumerable<SpringColliderSerialization.TransformSerializer> SerializeTransformRecords(IEnumerable<TextRecordParsing.Record> sourceRecords, List<DynamicsSetup.ParseMessage> errorRecords)
		{
			return null;
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x00018E28 File Offset: 0x00017028
		[Token(Token = "0x600411C")]
		[Address(RVA = "0x23ACD90", Offset = "0x23ACE91", VA = "0x23ACD90")]
		private static bool VerifyTransformRecord(SpringColliderSerialization.TransformSerializer transformSerializer, IEnumerable<string> validParentNames, out DynamicsSetup.ParseMessage error)
		{
			return default(bool);
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x00018E40 File Offset: 0x00017040
		[Token(Token = "0x600411D")]
		[Address(RVA = "0x23ACF20", Offset = "0x23AD021", VA = "0x23ACF20")]
		private static bool VerifyTransformRecords(IEnumerable<SpringColliderSerialization.TransformSerializer> sourceRecords, IEnumerable<string> validParentNames, List<SpringColliderSerialization.TransformSerializer> validRecords, List<DynamicsSetup.ParseMessage> errors)
		{
			return default(bool);
		}

		// Token: 0x06004DFE RID: 19966 RVA: 0x00018E58 File Offset: 0x00017058
		[Token(Token = "0x600411E")]
		[Address(RVA = "0x23AD450", Offset = "0x23AD551", VA = "0x23AD450")]
		private static bool VerifyColliderRecords(IEnumerable<SpringColliderSerialization.IColliderSerializer> colliderRecords, GameObject rootObject, IEnumerable<string> validParentNames, List<SpringColliderSerialization.IColliderSerializer> validRecords, List<DynamicsSetup.ParseMessage> errors)
		{
			return default(bool);
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411F")]
		[Address(RVA = "0x23ADBE0", Offset = "0x23ADCE1", VA = "0x23ADBE0")]
		private static GameObject BuildTransformFromRecord(Dictionary<string, Transform> objectMap, SpringColliderSerialization.TransformSerializer serializer)
		{
			return null;
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x00018E70 File Offset: 0x00017070
		[Token(Token = "0x6004120")]
		[Address(RVA = "0x23ADD90", Offset = "0x23ADE91", VA = "0x23ADD90")]
		private static bool BuildColliderFromRecord(Dictionary<string, Transform> objectMap, SpringColliderSerialization.IColliderSerializer colliderSerializer)
		{
			return default(bool);
		}

		// Token: 0x06004E01 RID: 19969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004121")]
		[Address(RVA = "0x23ADF10", Offset = "0x23AE011", VA = "0x23ADF10")]
		private static void BuildDynamicsNulls(Dictionary<string, Transform> objectMap, IEnumerable<SpringColliderSerialization.TransformSerializer> records)
		{
		}

		// Token: 0x06004E02 RID: 19970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004122")]
		[Address(RVA = "0x23AE430", Offset = "0x23AE531", VA = "0x23AE430")]
		private static void BuildComponents(Dictionary<string, Transform> objectMap, IEnumerable<TextRecordParsing.Record> records)
		{
		}

		// Token: 0x0400AF48 RID: 44872
		[Token(Token = "0x40083FF")]
		private const string SphereColliderToken = "sp";

		// Token: 0x0400AF49 RID: 44873
		[Token(Token = "0x4008400")]
		private const string CapsuleColliderToken = "cp";

		// Token: 0x0400AF4A RID: 44874
		[Token(Token = "0x4008401")]
		private const string PanelColliderToken = "pa";

		// Token: 0x02000BF3 RID: 3059
		[Token(Token = "0x2001388")]
		public class ParsedColliderSetup
		{
			// Token: 0x17000A16 RID: 2582
			// (get) Token: 0x06004E03 RID: 19971 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06004E04 RID: 19972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000DD7")]
			public IEnumerable<DynamicsSetup.ParseMessage> Errors
			{
				[Token(Token = "0x60077B3")]
				[Address(RVA = "0x23AF220", Offset = "0x23AF321", VA = "0x23AF220")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4720", Offset = "0x1B4821")]
				get
				{
					return null;
				}
				[Token(Token = "0x60077B4")]
				[Address(RVA = "0x23AF230", Offset = "0x23AF331", VA = "0x23AF230")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B4730", Offset = "0x1B4831")]
				set
				{
				}
			}

			// Token: 0x06004E05 RID: 19973 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077B5")]
			[Address(RVA = "0x23AF240", Offset = "0x23AF341", VA = "0x23AF240")]
			public static SpringColliderSerialization.ParsedColliderSetup ReadColliderSetupFromText(GameObject colliderRoot, string recordText)
			{
				return null;
			}

			// Token: 0x06004E06 RID: 19974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077B6")]
			[Address(RVA = "0x23AFC00", Offset = "0x23AFD01", VA = "0x23AFC00")]
			public void BuildObjects(GameObject colliderRoot)
			{
			}

			// Token: 0x06004E07 RID: 19975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077B7")]
			[Address(RVA = "0x23B0290", Offset = "0x23B0391", VA = "0x23B0290")]
			public IEnumerable<string> GetColliderNames()
			{
				return null;
			}

			// Token: 0x06004E08 RID: 19976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077B8")]
			[Address(RVA = "0x23AFBF0", Offset = "0x23AFCF1", VA = "0x23AFBF0")]
			public ParsedColliderSetup()
			{
			}

			// Token: 0x0400AF4B RID: 44875
			[Token(Token = "0x401B797")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1958C0", Offset = "0x1959C1")]
			private IEnumerable<DynamicsSetup.ParseMessage> <Errors>k__BackingField;

			// Token: 0x0400AF4C RID: 44876
			[Token(Token = "0x401B798")]
			[FieldOffset(Offset = "0x18")]
			private IEnumerable<SpringColliderSerialization.IColliderSerializer> colliderRecords;

			// Token: 0x0400AF4D RID: 44877
			[Token(Token = "0x401B799")]
			[FieldOffset(Offset = "0x20")]
			private IEnumerable<SpringColliderSerialization.TransformSerializer> dynamicsNullRecords;

			// Token: 0x0400AF4E RID: 44878
			[Token(Token = "0x401B79A")]
			[FieldOffset(Offset = "0x28")]
			private List<TextRecordParsing.Record> componentRecords;

			// Token: 0x02000BF4 RID: 3060
			[Token(Token = "0x2001657")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AE40", Offset = "0x15AF41")]
			[Serializable]
			private sealed class <>c
			{
				// Token: 0x06004E0A RID: 19978 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080B5")]
				[Address(RVA = "0x23B0410", Offset = "0x23B0511", VA = "0x23B0410")]
				public <>c()
				{
				}

				// Token: 0x06004E0B RID: 19979 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080B6")]
				[Address(RVA = "0x23B0420", Offset = "0x23B0521", VA = "0x23B0420")]
				internal string <ReadColliderSetupFromText>b__4_0(Transform item)
				{
					return null;
				}

				// Token: 0x06004E0C RID: 19980 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080B7")]
				[Address(RVA = "0x23B0440", Offset = "0x23B0541", VA = "0x23B0440")]
				internal string <ReadColliderSetupFromText>b__4_1(SpringColliderSerialization.TransformSerializer item)
				{
					return null;
				}

				// Token: 0x06004E0D RID: 19981 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60080B8")]
				[Address(RVA = "0x23B0460", Offset = "0x23B0561", VA = "0x23B0460")]
				internal string <GetColliderNames>b__6_0(SpringColliderSerialization.IColliderSerializer item)
				{
					return null;
				}

				// Token: 0x0400AF4F RID: 44879
				[Token(Token = "0x401C415")]
				[FieldOffset(Offset = "0x0")]
				public static readonly SpringColliderSerialization.ParsedColliderSetup.<>c <>9;

				// Token: 0x0400AF50 RID: 44880
				[Token(Token = "0x401C416")]
				[FieldOffset(Offset = "0x8")]
				public static Func<Transform, string> <>9__4_0;

				// Token: 0x0400AF51 RID: 44881
				[Token(Token = "0x401C417")]
				[FieldOffset(Offset = "0x10")]
				public static Func<SpringColliderSerialization.TransformSerializer, string> <>9__4_1;

				// Token: 0x0400AF52 RID: 44882
				[Token(Token = "0x401C418")]
				[FieldOffset(Offset = "0x18")]
				public static Func<SpringColliderSerialization.IColliderSerializer, string> <>9__6_0;
			}
		}

		// Token: 0x02000BF5 RID: 3061
		[Token(Token = "0x2001389")]
		private class TransformSerializer
		{
			// Token: 0x06004E0E RID: 19982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077B9")]
			[Address(RVA = "0x23ABA00", Offset = "0x23ABB01", VA = "0x23ABA00")]
			public TransformSerializer()
			{
			}

			// Token: 0x0400AF53 RID: 44883
			[Token(Token = "0x401B79B")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0400AF54 RID: 44884
			[Token(Token = "0x401B79C")]
			[FieldOffset(Offset = "0x18")]
			public string parentName;

			// Token: 0x0400AF55 RID: 44885
			[Token(Token = "0x401B79D")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 position;

			// Token: 0x0400AF56 RID: 44886
			[Token(Token = "0x401B79E")]
			[FieldOffset(Offset = "0x2C")]
			public Vector3 eulerAngles;

			// Token: 0x0400AF57 RID: 44887
			[Token(Token = "0x401B79F")]
			[FieldOffset(Offset = "0x38")]
			public Vector3 scale;
		}

		// Token: 0x02000BF6 RID: 3062
		[Token(Token = "0x200138A")]
		private class ColliderSerializerBaseInfo
		{
			// Token: 0x06004E0F RID: 19983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077BA")]
			[Address(RVA = "0x23ABAB0", Offset = "0x23ABBB1", VA = "0x23ABAB0")]
			public ColliderSerializerBaseInfo()
			{
			}

			// Token: 0x0400AF58 RID: 44888
			[Token(Token = "0x401B7A0")]
			[FieldOffset(Offset = "0x10")]
			public SpringColliderSerialization.TransformSerializer transform;

			// Token: 0x0400AF59 RID: 44889
			[Token(Token = "0x401B7A1")]
			[FieldOffset(Offset = "0x18")]
			public string colliderType;
		}

		// Token: 0x02000BF7 RID: 3063
		[Token(Token = "0x200138B")]
		private interface IColliderSerializer
		{
			// Token: 0x06004E10 RID: 19984
			[Token(Token = "0x60077BB")]
			SpringColliderSerialization.ColliderSerializerBaseInfo GetBaseInfo();

			// Token: 0x06004E11 RID: 19985
			[Token(Token = "0x60077BC")]
			Component BuildColliderComponent(GameObject gameObject);

			// Token: 0x06004E12 RID: 19986
			[Token(Token = "0x60077BD")]
			string GetLinkedRendererName();
		}

		// Token: 0x02000BF8 RID: 3064
		[Token(Token = "0x200138C")]
		private class SphereColliderSerializer : SpringColliderSerialization.IColliderSerializer
		{
			// Token: 0x06004E13 RID: 19987 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077BE")]
			[Address(RVA = "0x23B0530", Offset = "0x23B0631", VA = "0x23B0530", Slot = "4")]
			public SpringColliderSerialization.ColliderSerializerBaseInfo GetBaseInfo()
			{
				return null;
			}

			// Token: 0x06004E14 RID: 19988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077BF")]
			[Address(RVA = "0x23B0540", Offset = "0x23B0641", VA = "0x23B0540", Slot = "5")]
			public Component BuildColliderComponent(GameObject gameObject)
			{
				return null;
			}

			// Token: 0x06004E15 RID: 19989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077C0")]
			[Address(RVA = "0x23B0600", Offset = "0x23B0701", VA = "0x23B0600", Slot = "6")]
			public string GetLinkedRendererName()
			{
				return null;
			}

			// Token: 0x06004E16 RID: 19990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077C1")]
			[Address(RVA = "0x23ABC00", Offset = "0x23ABD01", VA = "0x23ABC00")]
			public SphereColliderSerializer()
			{
			}

			// Token: 0x0400AF5A RID: 44890
			[Token(Token = "0x401B7A2")]
			[FieldOffset(Offset = "0x10")]
			public SpringColliderSerialization.ColliderSerializerBaseInfo baseInfo;

			// Token: 0x0400AF5B RID: 44891
			[Token(Token = "0x401B7A3")]
			[FieldOffset(Offset = "0x18")]
			public float radius;

			// Token: 0x0400AF5C RID: 44892
			[Token(Token = "0x401B7A4")]
			[FieldOffset(Offset = "0x20")]
			public string linkedRenderer;
		}

		// Token: 0x02000BF9 RID: 3065
		[Token(Token = "0x200138D")]
		private class CapsuleColliderSerializer : SpringColliderSerialization.IColliderSerializer
		{
			// Token: 0x06004E17 RID: 19991 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077C2")]
			[Address(RVA = "0x23AF060", Offset = "0x23AF161", VA = "0x23AF060", Slot = "4")]
			public SpringColliderSerialization.ColliderSerializerBaseInfo GetBaseInfo()
			{
				return null;
			}

			// Token: 0x06004E18 RID: 19992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077C3")]
			[Address(RVA = "0x23AF070", Offset = "0x23AF171", VA = "0x23AF070", Slot = "5")]
			public Component BuildColliderComponent(GameObject gameObject)
			{
				return null;
			}

			// Token: 0x06004E19 RID: 19993 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077C4")]
			[Address(RVA = "0x23AF130", Offset = "0x23AF231", VA = "0x23AF130", Slot = "6")]
			public string GetLinkedRendererName()
			{
				return null;
			}

			// Token: 0x06004E1A RID: 19994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077C5")]
			[Address(RVA = "0x23ABD50", Offset = "0x23ABE51", VA = "0x23ABD50")]
			public CapsuleColliderSerializer()
			{
			}

			// Token: 0x0400AF5D RID: 44893
			[Token(Token = "0x401B7A5")]
			[FieldOffset(Offset = "0x10")]
			public SpringColliderSerialization.ColliderSerializerBaseInfo baseInfo;

			// Token: 0x0400AF5E RID: 44894
			[Token(Token = "0x401B7A6")]
			[FieldOffset(Offset = "0x18")]
			public float radius;

			// Token: 0x0400AF5F RID: 44895
			[Token(Token = "0x401B7A7")]
			[FieldOffset(Offset = "0x1C")]
			public float height;

			// Token: 0x0400AF60 RID: 44896
			[Token(Token = "0x401B7A8")]
			[FieldOffset(Offset = "0x20")]
			public string linkedRenderer;
		}

		// Token: 0x02000BFA RID: 3066
		[Token(Token = "0x200138E")]
		private class PanelColliderSerializer : SpringColliderSerialization.IColliderSerializer
		{
			// Token: 0x06004E1B RID: 19995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077C6")]
			[Address(RVA = "0x23AF140", Offset = "0x23AF241", VA = "0x23AF140", Slot = "4")]
			public SpringColliderSerialization.ColliderSerializerBaseInfo GetBaseInfo()
			{
				return null;
			}

			// Token: 0x06004E1C RID: 19996 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077C7")]
			[Address(RVA = "0x23AF150", Offset = "0x23AF251", VA = "0x23AF150", Slot = "5")]
			public Component BuildColliderComponent(GameObject gameObject)
			{
				return null;
			}

			// Token: 0x06004E1D RID: 19997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077C8")]
			[Address(RVA = "0x23AF210", Offset = "0x23AF311", VA = "0x23AF210", Slot = "6")]
			public string GetLinkedRendererName()
			{
				return null;
			}

			// Token: 0x06004E1E RID: 19998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077C9")]
			[Address(RVA = "0x23ABEA0", Offset = "0x23ABFA1", VA = "0x23ABEA0")]
			public PanelColliderSerializer()
			{
			}

			// Token: 0x0400AF61 RID: 44897
			[Token(Token = "0x401B7A9")]
			[FieldOffset(Offset = "0x10")]
			public SpringColliderSerialization.ColliderSerializerBaseInfo baseInfo;

			// Token: 0x0400AF62 RID: 44898
			[Token(Token = "0x401B7AA")]
			[FieldOffset(Offset = "0x18")]
			public float width;

			// Token: 0x0400AF63 RID: 44899
			[Token(Token = "0x401B7AB")]
			[FieldOffset(Offset = "0x1C")]
			public float height;

			// Token: 0x0400AF64 RID: 44900
			[Token(Token = "0x401B7AC")]
			[FieldOffset(Offset = "0x20")]
			public string linkedRenderer;
		}

		// Token: 0x02000BFB RID: 3067
		[Token(Token = "0x200138F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159530", Offset = "0x159631")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004E20 RID: 20000 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077CB")]
			[Address(RVA = "0x23AEE80", Offset = "0x23AEF81", VA = "0x23AEE80")]
			public <>c()
			{
			}

			// Token: 0x06004E21 RID: 20001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077CC")]
			[Address(RVA = "0x23AEE90", Offset = "0x23AEF91", VA = "0x23AEE90")]
			internal SpringColliderSerialization.SphereColliderSerializer <AppendColliders>b__1_0(SpringSphereCollider item)
			{
				return null;
			}

			// Token: 0x06004E22 RID: 20002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077CD")]
			[Address(RVA = "0x23AEEA0", Offset = "0x23AEFA1", VA = "0x23AEEA0")]
			internal SpringColliderSerialization.CapsuleColliderSerializer <AppendColliders>b__1_1(SpringCapsuleCollider item)
			{
				return null;
			}

			// Token: 0x06004E23 RID: 20003 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077CE")]
			[Address(RVA = "0x23AEEB0", Offset = "0x23AEFB1", VA = "0x23AEEB0")]
			internal SpringColliderSerialization.PanelColliderSerializer <AppendColliders>b__1_2(SpringPanelCollider item)
			{
				return null;
			}

			// Token: 0x06004E24 RID: 20004 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077CF")]
			[Address(RVA = "0x23AEEC0", Offset = "0x23AEFC1", VA = "0x23AEEC0")]
			internal SpringColliderSerialization.TransformSerializer <AppendDynamicsNulls>b__8_0(DynamicsNull item)
			{
				return null;
			}

			// Token: 0x0400AF65 RID: 44901
			[Token(Token = "0x401B7AD")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SpringColliderSerialization.<>c <>9;

			// Token: 0x0400AF66 RID: 44902
			[Token(Token = "0x401B7AE")]
			[FieldOffset(Offset = "0x8")]
			public static Func<SpringSphereCollider, SpringColliderSerialization.SphereColliderSerializer> <>9__1_0;

			// Token: 0x0400AF67 RID: 44903
			[Token(Token = "0x401B7AF")]
			[FieldOffset(Offset = "0x10")]
			public static Func<SpringCapsuleCollider, SpringColliderSerialization.CapsuleColliderSerializer> <>9__1_1;

			// Token: 0x0400AF68 RID: 44904
			[Token(Token = "0x401B7B0")]
			[FieldOffset(Offset = "0x18")]
			public static Func<SpringPanelCollider, SpringColliderSerialization.PanelColliderSerializer> <>9__1_2;

			// Token: 0x0400AF69 RID: 44905
			[Token(Token = "0x401B7B1")]
			[FieldOffset(Offset = "0x20")]
			public static Func<DynamicsNull, SpringColliderSerialization.TransformSerializer> <>9__8_0;
		}

		// Token: 0x02000BFC RID: 3068
		[Token(Token = "0x2001390")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159540", Offset = "0x159641")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06004E25 RID: 20005 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077D0")]
			[Address(RVA = "0x23AC380", Offset = "0x23AC481", VA = "0x23AC380")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06004E26 RID: 20006 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60077D1")]
			[Address(RVA = "0x23AEEF0", Offset = "0x23AEFF1", VA = "0x23AEEF0")]
			internal Transform <GetChildByName>b__0(int index)
			{
				return null;
			}

			// Token: 0x06004E27 RID: 20007 RVA: 0x00018E88 File Offset: 0x00017088
			[Token(Token = "0x60077D2")]
			[Address(RVA = "0x23AEF10", Offset = "0x23AF011", VA = "0x23AEF10")]
			internal bool <GetChildByName>b__1(Transform child)
			{
				return default(bool);
			}

			// Token: 0x0400AF6A RID: 44906
			[Token(Token = "0x401B7B2")]
			[FieldOffset(Offset = "0x10")]
			public Transform parent;

			// Token: 0x0400AF6B RID: 44907
			[Token(Token = "0x401B7B3")]
			[FieldOffset(Offset = "0x18")]
			public string name;
		}

		// Token: 0x02000BFD RID: 3069
		[Token(Token = "0x2001391")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159550", Offset = "0x159651")]
		private sealed class <>c__DisplayClass27_0
		{
			// Token: 0x06004E28 RID: 20008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077D3")]
			[Address(RVA = "0x23AD440", Offset = "0x23AD541", VA = "0x23AD440")]
			public <>c__DisplayClass27_0()
			{
			}

			// Token: 0x06004E29 RID: 20009 RVA: 0x00018EA0 File Offset: 0x000170A0
			[Token(Token = "0x60077D4")]
			[Address(RVA = "0x23AEF50", Offset = "0x23AF051", VA = "0x23AEF50")]
			internal bool <VerifyTransformRecords>b__0(SpringColliderSerialization.TransformSerializer item)
			{
				return default(bool);
			}

			// Token: 0x0400AF6C RID: 44908
			[Token(Token = "0x401B7B4")]
			[FieldOffset(Offset = "0x10")]
			public SpringColliderSerialization.TransformSerializer sourceRecord;
		}

		// Token: 0x02000BFE RID: 3070
		[Token(Token = "0x2001392")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x159560", Offset = "0x159661")]
		private sealed class <>c__DisplayClass28_0
		{
			// Token: 0x06004E2A RID: 20010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60077D5")]
			[Address(RVA = "0x23ADBD0", Offset = "0x23ADCD1", VA = "0x23ADBD0")]
			public <>c__DisplayClass28_0()
			{
			}

			// Token: 0x06004E2B RID: 20011 RVA: 0x00018EB8 File Offset: 0x000170B8
			[Token(Token = "0x60077D6")]
			[Address(RVA = "0x23AEF80", Offset = "0x23AF081", VA = "0x23AEF80")]
			internal bool <VerifyColliderRecords>b__0(SpringColliderSerialization.IColliderSerializer item)
			{
				return default(bool);
			}

			// Token: 0x0400AF6D RID: 44909
			[Token(Token = "0x401B7B5")]
			[FieldOffset(Offset = "0x10")]
			public string objectName;
		}
	}
}
