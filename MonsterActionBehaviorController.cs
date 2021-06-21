using System;
using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using Il2CppDummyDll;

// Token: 0x02000044 RID: 68
[Token(Token = "0x2000042")]
public class MonsterActionBehaviorController : ActionBehaviorController
{
	// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1D80F30", Offset = "0x1D81031", VA = "0x1D80F30")]
	private MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter CreateMonsterActionBehaviorCommandParameter(ActionBehaviorCommandInformation command)
	{
		return null;
	}

	// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1D81390", Offset = "0x1D81491", VA = "0x1D81390")]
	private List<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter> CreateMonsterActionBehaviorCommandParameterList(MonsterActionBehaviorDataID id, BehaviorTree behaviorTree)
	{
		return null;
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1D816D0", Offset = "0x1D817D1", VA = "0x1D816D0")]
	private Func<bool> GetCanAction(MonsterActionBehaviorData param)
	{
		return null;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1D819B0", Offset = "0x1D81AB1", VA = "0x1D819B0")]
	public MonsterActionBehaviorController(MonsterBehaviorController owner)
	{
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1D81A80", Offset = "0x1D81B81", VA = "0x1D81A80")]
	public void Setup(MonsterBehaviorController controller, BehaviorTree behaviorTree)
	{
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1D82480", Offset = "0x1D82581", VA = "0x1D82480")]
	public void SetExecuteFlag(bool isExecute)
	{
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1D82520", Offset = "0x1D82621", VA = "0x1D82520")]
	public void SelectMonsterAction()
	{
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1D82B00", Offset = "0x1D82C01", VA = "0x1D82B00")]
	public List<MonsterActionBehaviorType> GetMonsterBehaviorList()
	{
		return null;
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1D82B10", Offset = "0x1D82C11", VA = "0x1D82B10")]
	public void Execute(int index)
	{
	}

	// Token: 0x040000B7 RID: 183
	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x18")]
	public MonsterBehaviorController MonsterOwner;

	// Token: 0x040000B8 RID: 184
	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x20")]
	public SharedMovementBehaviorType SharedMovementBehaviorType;

	// Token: 0x040000B9 RID: 185
	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x28")]
	public SharedFloat MaxWaitInterval;

	// Token: 0x040000BA RID: 186
	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x30")]
	public SharedFloat MinWaitInterval;

	// Token: 0x040000BB RID: 187
	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x38")]
	public SharedFloat MoveAroundRange;

	// Token: 0x040000BC RID: 188
	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x40")]
	public SharedFloat MoveAroundAngle;

	// Token: 0x040000BD RID: 189
	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x48")]
	public SharedBool IsReleseEyes;

	// Token: 0x040000BE RID: 190
	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x50")]
	public SharedFloat LeaveRange;

	// Token: 0x040000BF RID: 191
	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x58")]
	public SharedFloat CloseRange;

	// Token: 0x040000C0 RID: 192
	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x60")]
	public SharedFloat MoveSpeedScale;

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000BA")]
	[FieldOffset(Offset = "0x68")]
	public SharedFloat TakebehindRange;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000BB")]
	[FieldOffset(Offset = "0x70")]
	public SharedFloat JumpTime;

	// Token: 0x040000C3 RID: 195
	[Token(Token = "0x40000BC")]
	[FieldOffset(Offset = "0x78")]
	public SharedVector3 JumpArrivePosition;

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000BD")]
	[FieldOffset(Offset = "0x80")]
	public SharedString CrossFadeAnimatorStateName;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000BE")]
	[FieldOffset(Offset = "0x88")]
	public SharedBool OnlyUseMaxRange;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000BF")]
	[FieldOffset(Offset = "0x90")]
	public SharedVector3 MovePosition;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C0")]
	[FieldOffset(Offset = "0x98")]
	public SharedVector3 WarpPosition;

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<MonsterActionBehaviorDataID, List<MonsterActionBehaviorController.MonsterActionBehaviorCommandParameter>> ActionBehaviorCodeDic;

	// Token: 0x040000C9 RID: 201
	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0xA8")]
	public List<ActionBehaviorCommandBase> CurrentActionBehaviorCommandList;

	// Token: 0x040000CA RID: 202
	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0xB0")]
	public List<MonsterActionBehaviorType> CurrentMonsterActionBehaviorTypeList;

	// Token: 0x040000CB RID: 203
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0xB8")]
	private List<MonsterActionBehaviorController.ExecuteMonsterActionBehaviorParameter> ExecuteMonsterActionBehaviorList;

	// Token: 0x040000CC RID: 204
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0xC0")]
	private MonsterActionBehaviorDataID CurrentActionBehaviorDataID;

	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000F8C")]
	public class ExecuteMonsterActionBehaviorParameter
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AEC")]
		[Address(RVA = "0x1D82440", Offset = "0x1D82541", VA = "0x1D82440")]
		public ExecuteMonsterActionBehaviorParameter(MonsterActionBehaviorData actionBehaviorData)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x6006AED")]
		[Address(RVA = "0x1D829E0", Offset = "0x1D82AE1", VA = "0x1D829E0")]
		public int GetRato(bool IsDamageActionTarget)
		{
			return 0;
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x4018C7F")]
		[FieldOffset(Offset = "0x10")]
		public readonly MonsterActionBehaviorData ActionBehaviorData;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x4018C80")]
		[FieldOffset(Offset = "0x18")]
		public Func<bool> CanAction;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x4018C81")]
		[FieldOffset(Offset = "0x20")]
		public bool Executed;
	}

	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000F8D")]
	public class MonsterActionBehaviorCommandParameter
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AEE")]
		[Address(RVA = "0x1D812A0", Offset = "0x1D813A1", VA = "0x1D812A0")]
		public MonsterActionBehaviorCommandParameter()
		{
		}

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x4018C82")]
		[FieldOffset(Offset = "0x10")]
		public ActionBehaviorCommandBase ActionBehaviorCommandBase;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x4018C83")]
		[FieldOffset(Offset = "0x18")]
		public MonsterActionBehaviorType MonsterActionBehaviorType;
	}

	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000F8E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156EE0", Offset = "0x156FE1")]
	private sealed class <>c__DisplayClass26_0
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AEF")]
		[Address(RVA = "0x1D81980", Offset = "0x1D81A81", VA = "0x1D81980")]
		public <>c__DisplayClass26_0()
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x6006AF0")]
		[Address(RVA = "0x1D82C30", Offset = "0x1D82D31", VA = "0x1D82C30")]
		internal bool <GetCanAction>b__0()
		{
			return default(bool);
		}

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x4018C84")]
		[FieldOffset(Offset = "0x10")]
		public MonsterActionBehaviorController <>4__this;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x4018C85")]
		[FieldOffset(Offset = "0x18")]
		public MonsterActionBehaviorData param;
	}

	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000F8F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156EF0", Offset = "0x156FF1")]
	private sealed class <>c__DisplayClass26_1
	{
		// Token: 0x060000CA RID: 202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF1")]
		[Address(RVA = "0x1D81990", Offset = "0x1D81A91", VA = "0x1D81990")]
		public <>c__DisplayClass26_1()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x6006AF2")]
		[Address(RVA = "0x1D82F40", Offset = "0x1D83041", VA = "0x1D82F40")]
		internal bool <GetCanAction>b__2()
		{
			return default(bool);
		}

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x4018C86")]
		[FieldOffset(Offset = "0x10")]
		public Func<int, int, bool> cpmparisonOperator;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x4018C87")]
		[FieldOffset(Offset = "0x18")]
		public MonsterActionBehaviorController.<>c__DisplayClass26_0 CS$<>8__locals1;
	}

	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000F90")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156F00", Offset = "0x157001")]
	private sealed class <>c__DisplayClass26_2
	{
		// Token: 0x060000CC RID: 204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF3")]
		[Address(RVA = "0x1D819A0", Offset = "0x1D81AA1", VA = "0x1D819A0")]
		public <>c__DisplayClass26_2()
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x6006AF4")]
		[Address(RVA = "0x1D82FF0", Offset = "0x1D830F1", VA = "0x1D82FF0")]
		internal bool <GetCanAction>b__3()
		{
			return default(bool);
		}

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x4018C88")]
		[FieldOffset(Offset = "0x10")]
		public Func<int, int, bool> cpmparisonOperator;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x4018C89")]
		[FieldOffset(Offset = "0x18")]
		public MonsterActionBehaviorController.<>c__DisplayClass26_0 CS$<>8__locals2;
	}

	// Token: 0x0200004A RID: 74
	[Token(Token = "0x2000F91")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x156F10", Offset = "0x157011")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AF6")]
		[Address(RVA = "0x1D82C10", Offset = "0x1D82D11", VA = "0x1D82C10")]
		public <>c()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x6006AF7")]
		[Address(RVA = "0x1D82C20", Offset = "0x1D82D21", VA = "0x1D82C20")]
		internal bool <GetCanAction>b__26_1()
		{
			return default(bool);
		}

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x4018C8A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly MonsterActionBehaviorController.<>c <>9;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x4018C8B")]
		[FieldOffset(Offset = "0x8")]
		public static Func<bool> <>9__26_1;
	}
}
