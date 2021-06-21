using System;
using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x0200004B RID: 75
[Token(Token = "0x2000043")]
public class NPCActionBehaviorController : ActionBehaviorController
{
	// Token: 0x060000D1 RID: 209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1E1E440", Offset = "0x1E1E541", VA = "0x1E1E440")]
	public NPCActionBehaviorController(PartnerNPCBehaviorController owner)
	{
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1E1E520", Offset = "0x1E1E621", VA = "0x1E1E520")]
	private NPCActionBehaviorController.PartnerNPCActionBehaviorParam CreatePartnerNPCActionBehaviorParam(ActionBehaviorCommandInformation command)
	{
		return null;
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1E1E9C0", Offset = "0x1E1EAC1", VA = "0x1E1E9C0")]
	private List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam> CreateNPCActionBehaviorCommandParameterList(NPCActionBehaviorDataID id, BehaviorTree behaviorTree)
	{
		return null;
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1E1EE00", Offset = "0x1E1EF01", VA = "0x1E1EE00")]
	public Func<Character, bool> CreateFindTargetFunc(NPCFindTargetDataID dataID)
	{
		return null;
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1E1F650", Offset = "0x1E1F751", VA = "0x1E1F650")]
	private List<NPCActionData> GetDataList()
	{
		return null;
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1E1F9D0", Offset = "0x1E1FAD1", VA = "0x1E1F9D0")]
	public void Setup(BehaviorTree behaviorTree)
	{
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1E20000", Offset = "0x1E20101", VA = "0x1E20000")]
	private Character GetRandomTaget(List<Character> targetList)
	{
		return null;
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1E200A0", Offset = "0x1E201A1", VA = "0x1E200A0")]
	private bool CanActionFindTarget(NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter param)
	{
		return default(bool);
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1E20320", Offset = "0x1E20421", VA = "0x1E20320")]
	private Character FindTarget(NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter param)
	{
		return null;
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1E20560", Offset = "0x1E20661", VA = "0x1E20560")]
	public NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter SelectNPCOrderAction(List<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter> paramList, bool ignoreCoolCount = false)
	{
		return null;
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1E20A10", Offset = "0x1E20B11", VA = "0x1E20A10")]
	public void SelectNPCAction()
	{
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1E21460", Offset = "0x1E21561", VA = "0x1E21460")]
	public List<PartnerNPCActionBehaviorType> GetActionList()
	{
		return null;
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1E21470", Offset = "0x1E21571", VA = "0x1E21470")]
	public void Execute(int index)
	{
	}

	// Token: 0x040000DA RID: 218
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x18")]
	public PartnerNPCBehaviorController NPCOwner;

	// Token: 0x040000DB RID: 219
	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x20")]
	public List<NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter> ExecuteNPCActionBehaviorList;

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x28")]
	public NPCActionBehaviorDataID CurrentSelectActionBehaviorDataID;

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x2C")]
	public int CurrentSelectBehaviorParameterIndex;

	// Token: 0x040000DE RID: 222
	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<NPCActionBehaviorDataID, List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam>> ActionBehaviorCodeDic;

	// Token: 0x040000DF RID: 223
	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x38")]
	private NPCActionData NotSelectData;

	// Token: 0x040000E0 RID: 224
	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x70")]
	private List<NPCActionBehaviorController.PartnerNPCActionBehaviorParam> NotSelectCode;

	// Token: 0x040000E1 RID: 225
	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x78")]
	public List<ActionBehaviorCommandBase> CurrentActionBehaviorCommandList;

	// Token: 0x040000E2 RID: 226
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x80")]
	public List<PartnerNPCActionBehaviorType> CurrentActionBehaviorTypeList;

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x88")]
	private int MaxOrder;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x90")]
	public SharedGameObject Target;

	// Token: 0x040000E5 RID: 229
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x98")]
	private SharedFloat BehaviorWaitTime;

	// Token: 0x040000E6 RID: 230
	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0xA0")]
	public Character TargetCharacter;

	// Token: 0x040000E7 RID: 231
	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0xA8")]
	public Character LatestDamagedTarget;

	// Token: 0x0200004C RID: 76
	[Token(Token = "0x2000F92")]
	public class ExecuteNPCActionBehaviorParameter
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF8")]
		[Address(RVA = "0x1E1FFB0", Offset = "0x1E200B1", VA = "0x1E1FFB0")]
		public ExecuteNPCActionBehaviorParameter(int index, NPCActionData actionBehaviorData)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x6006AF9")]
		[Address(RVA = "0x1E21DE0", Offset = "0x1E21EE1", VA = "0x1E21DE0")]
		private bool CanActionCheckEquip(ItemData equipItemData)
		{
			return default(bool);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x6006AFA")]
		[Address(RVA = "0x1E21E80", Offset = "0x1E21F81", VA = "0x1E21E80")]
		private bool CanActionCheckRelationship(PartnerNPCController owner)
		{
			return default(bool);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x6006AFB")]
		[Address(RVA = "0x1E21F70", Offset = "0x1E22071", VA = "0x1E21F70")]
		private bool CanActionCheckLevel(PartnerNPCController owner)
		{
			return default(bool);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x6006AFC")]
		[Address(RVA = "0x1E21FC0", Offset = "0x1E220C1", VA = "0x1E21FC0")]
		private bool CanActionCheckNotSeal(PartnerNPCController owner)
		{
			return default(bool);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x6006AFD")]
		[Address(RVA = "0x1E21250", Offset = "0x1E21351", VA = "0x1E21250")]
		public bool CanActionCheck(PartnerNPCController owner)
		{
			return default(bool);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x6006AFE")]
		[Address(RVA = "0x1E21440", Offset = "0x1E21541", VA = "0x1E21440")]
		public bool IsForceActionCheckComboActionData(NPCActionBehaviorDataID previousActionBehaviorDataID)
		{
			return default(bool);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x6006AFF")]
		[Address(RVA = "0x1E21DD0", Offset = "0x1E21ED1", VA = "0x1E21DD0")]
		public bool IsMeetsOrder(int order)
		{
			return default(bool);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x6006B00")]
		[Address(RVA = "0x1E209E0", Offset = "0x1E20AE1", VA = "0x1E209E0")]
		public int GetRaito(bool ignoreCoolCount)
		{
			return 0;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B01")]
		[Address(RVA = "0x1E213A0", Offset = "0x1E214A1", VA = "0x1E213A0")]
		public void UpdateCoolCount()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B02")]
		[Address(RVA = "0x1E20A00", Offset = "0x1E20B01", VA = "0x1E20A00")]
		public void ResetCoolCount()
		{
		}

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x4018C8C")]
		[FieldOffset(Offset = "0x10")]
		public readonly int Index;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x4018C8D")]
		[FieldOffset(Offset = "0x14")]
		public readonly NPCActionData ActionBehaviorData;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x4018C8E")]
		[FieldOffset(Offset = "0x50")]
		public Func<Character, bool> CanActionFindTargetFunc;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x4018C8F")]
		[FieldOffset(Offset = "0x58")]
		public Func<Character, bool> FindTargetFunc;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x4018C90")]
		[FieldOffset(Offset = "0x60")]
		public int CurrentCoolCount;
	}

	// Token: 0x0200004D RID: 77
	[Token(Token = "0x2000F93")]
	public class PartnerNPCActionBehaviorParam
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B03")]
		[Address(RVA = "0x1E1E970", Offset = "0x1E1EA71", VA = "0x1E1E970")]
		public PartnerNPCActionBehaviorParam()
		{
		}

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x4018C91")]
		[FieldOffset(Offset = "0x10")]
		public ActionBehaviorCommandBase Command;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x4018C92")]
		[FieldOffset(Offset = "0x18")]
		public PartnerNPCActionBehaviorType Type;
	}

	// Token: 0x0200004E RID: 78
	[Token(Token = "0x2000F94")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156F20", Offset = "0x157021")]
	private sealed class <>c__DisplayClass19_0
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B04")]
		[Address(RVA = "0x1E1F4A0", Offset = "0x1E1F5A1", VA = "0x1E1F4A0")]
		public <>c__DisplayClass19_0()
		{
		}

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x4018C93")]
		[FieldOffset(Offset = "0x10")]
		public NPCFindTargetDataTable findData;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x4018C94")]
		[FieldOffset(Offset = "0x18")]
		public NPCActionBehaviorController <>4__this;
	}

	// Token: 0x0200004F RID: 79
	[Token(Token = "0x2000F95")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156F30", Offset = "0x157031")]
	private sealed class <>c__DisplayClass19_1
	{
		// Token: 0x060000EB RID: 235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B05")]
		[Address(RVA = "0x1E1F620", Offset = "0x1E1F721", VA = "0x1E1F620")]
		public <>c__DisplayClass19_1()
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x6006B06")]
		[Address(RVA = "0x1E21A10", Offset = "0x1E21B11", VA = "0x1E21A10")]
		internal bool <CreateFindTargetFunc>b__7(Character character)
		{
			return default(bool);
		}

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x4018C95")]
		[FieldOffset(Offset = "0x10")]
		public Func<int, int, bool> func;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x4018C96")]
		[FieldOffset(Offset = "0x18")]
		public NPCActionBehaviorController.<>c__DisplayClass19_0 CS$<>8__locals1;
	}

	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000F96")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156F40", Offset = "0x157041")]
	private sealed class <>c__DisplayClass19_2
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B07")]
		[Address(RVA = "0x1E1F630", Offset = "0x1E1F731", VA = "0x1E1F630")]
		public <>c__DisplayClass19_2()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x6006B08")]
		[Address(RVA = "0x1E21B00", Offset = "0x1E21C01", VA = "0x1E21B00")]
		internal bool <CreateFindTargetFunc>b__8(Character character)
		{
			return default(bool);
		}

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x4018C97")]
		[FieldOffset(Offset = "0x10")]
		public Func<int, int, bool> func;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x4018C98")]
		[FieldOffset(Offset = "0x18")]
		public NPCActionBehaviorController.<>c__DisplayClass19_0 CS$<>8__locals2;
	}

	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000F97")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156F50", Offset = "0x157051")]
	private sealed class <>c__DisplayClass19_3
	{
		// Token: 0x060000EF RID: 239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B09")]
		[Address(RVA = "0x1E1F640", Offset = "0x1E1F741", VA = "0x1E1F640")]
		public <>c__DisplayClass19_3()
		{
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6006B0A")]
		[Address(RVA = "0x1E21BF0", Offset = "0x1E21CF1", VA = "0x1E21BF0")]
		internal bool <CreateFindTargetFunc>b__9(Character character)
		{
			return default(bool);
		}

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x4018C99")]
		[FieldOffset(Offset = "0x10")]
		public Func<float, float, bool> func;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x4018C9A")]
		[FieldOffset(Offset = "0x18")]
		public NPCActionBehaviorController.<>c__DisplayClass19_0 CS$<>8__locals3;
	}

	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000F98")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156F60", Offset = "0x157061")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0C")]
		[Address(RVA = "0x1E21570", Offset = "0x1E21671", VA = "0x1E21570")]
		public <>c()
		{
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6006B0D")]
		[Address(RVA = "0x1E21580", Offset = "0x1E21681", VA = "0x1E21580")]
		internal bool <CreateFindTargetFunc>b__19_0(Character character)
		{
			return default(bool);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6006B0E")]
		[Address(RVA = "0x1E21640", Offset = "0x1E21741", VA = "0x1E21640")]
		internal bool <CreateFindTargetFunc>b__19_1(Character character)
		{
			return default(bool);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x6006B0F")]
		[Address(RVA = "0x1E21700", Offset = "0x1E21801", VA = "0x1E21700")]
		internal bool <CreateFindTargetFunc>b__19_2(Character character)
		{
			return default(bool);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x6006B10")]
		[Address(RVA = "0x1E217C0", Offset = "0x1E218C1", VA = "0x1E217C0")]
		internal bool <CreateFindTargetFunc>b__19_3(Character character)
		{
			return default(bool);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x6006B11")]
		[Address(RVA = "0x1E21880", Offset = "0x1E21981", VA = "0x1E21880")]
		internal bool <CreateFindTargetFunc>b__19_4(Character character)
		{
			return default(bool);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x6006B12")]
		[Address(RVA = "0x1E21940", Offset = "0x1E21A41", VA = "0x1E21940")]
		internal bool <CreateFindTargetFunc>b__19_5(Character character)
		{
			return default(bool);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x6006B13")]
		[Address(RVA = "0x1E21A00", Offset = "0x1E21B01", VA = "0x1E21A00")]
		internal bool <CreateFindTargetFunc>b__19_6(Character character)
		{
			return default(bool);
		}

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x4018C9B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NPCActionBehaviorController.<>c <>9;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x4018C9C")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Character, bool> <>9__19_0;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x4018C9D")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Character, bool> <>9__19_1;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x4018C9E")]
		[FieldOffset(Offset = "0x18")]
		public static Func<Character, bool> <>9__19_2;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x4018C9F")]
		[FieldOffset(Offset = "0x20")]
		public static Func<Character, bool> <>9__19_3;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x4018CA0")]
		[FieldOffset(Offset = "0x28")]
		public static Func<Character, bool> <>9__19_4;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x4018CA1")]
		[FieldOffset(Offset = "0x30")]
		public static Func<Character, bool> <>9__19_5;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x4018CA2")]
		[FieldOffset(Offset = "0x38")]
		public static Func<Character, bool> <>9__19_6;
	}

	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000F99")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156F70", Offset = "0x157071")]
	private sealed class <>c__DisplayClass25_0
	{
		// Token: 0x060000FA RID: 250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B14")]
		[Address(RVA = "0x1E209D0", Offset = "0x1E20AD1", VA = "0x1E209D0")]
		public <>c__DisplayClass25_0()
		{
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x6006B15")]
		[Address(RVA = "0x1E21DA0", Offset = "0x1E21EA1", VA = "0x1E21DA0")]
		internal bool <SelectNPCOrderAction>b__0(NPCActionBehaviorController.ExecuteNPCActionBehaviorParameter listparam)
		{
			return default(bool);
		}

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x4018CA3")]
		[FieldOffset(Offset = "0x10")]
		public int i;
	}
}
