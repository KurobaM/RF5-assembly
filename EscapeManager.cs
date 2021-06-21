using System;
using Il2CppDummyDll;

// Token: 0x0200027A RID: 634
[Token(Token = "0x20001F8")]
public class EscapeManager : SingletonMonoBehaviour<EscapeManager>
{
	// Token: 0x170002E1 RID: 737
	// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00007308 File Offset: 0x00005508
	// (set) Token: 0x06000FDD RID: 4061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170002B7")]
	public bool InitCompleted
	{
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x1DAE1B0", Offset = "0x1DAE2B1", VA = "0x1DAE1B0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C2D0", Offset = "0x19C3D1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x1DAE1C0", Offset = "0x1DAE2C1", VA = "0x1DAE1C0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C2E0", Offset = "0x19C3E1")]
		private set
		{
		}
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x00007320 File Offset: 0x00005520
	[Token(Token = "0x6000E53")]
	[Address(RVA = "0x1DAE1D0", Offset = "0x1DAE2D1", VA = "0x1DAE1D0")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E54")]
	[Address(RVA = "0x1DAE1F0", Offset = "0x1DAE2F1", VA = "0x1DAE1F0")]
	public void OnDestroy()
	{
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E55")]
	[Address(RVA = "0x1DAE200", Offset = "0x1DAE301", VA = "0x1DAE200")]
	public void Init()
	{
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x00007338 File Offset: 0x00005538
	[Token(Token = "0x6000E56")]
	[Address(RVA = "0x1DAE210", Offset = "0x1DAE311", VA = "0x1DAE210")]
	public bool DoStart(Character chara, string sceneName, WarpPoints.WarpPoint warpPoint)
	{
		return default(bool);
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E57")]
	[Address(RVA = "0x1DAE490", Offset = "0x1DAE591", VA = "0x1DAE490")]
	private void Update()
	{
	}

	// Token: 0x06000FE3 RID: 4067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E58")]
	[Address(RVA = "0x1DAE6B0", Offset = "0x1DAE7B1", VA = "0x1DAE6B0")]
	private void OnTeleport()
	{
	}

	// Token: 0x06000FE4 RID: 4068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E59")]
	[Address(RVA = "0x1DAE4C0", Offset = "0x1DAE5C1", VA = "0x1DAE4C0")]
	private void OnUpdateStartLanding()
	{
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E5A")]
	[Address(RVA = "0x1DAE5E0", Offset = "0x1DAE6E1", VA = "0x1DAE5E0")]
	private void OnUpdateEnd()
	{
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E5B")]
	[Address(RVA = "0x1DAE6F0", Offset = "0x1DAE7F1", VA = "0x1DAE6F0")]
	public EscapeManager()
	{
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E5C")]
	[Address(RVA = "0x1DAE740", Offset = "0x1DAE841", VA = "0x1DAE740")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19C2F0", Offset = "0x19C3F1")]
	private void <OnUpdateStartLanding>b__13_0()
	{
	}

	// Token: 0x04000905 RID: 2309
	[Token(Token = "0x400071F")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15E960", Offset = "0x15EA61")]
	private bool <InitCompleted>k__BackingField;

	// Token: 0x04000906 RID: 2310
	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x1C")]
	private EscapeManager.State m_State;

	// Token: 0x04000907 RID: 2311
	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x20")]
	private Character m_chara;

	// Token: 0x0200027B RID: 635
	[Token(Token = "0x200100B")]
	private enum State
	{
		// Token: 0x04000909 RID: 2313
		[Token(Token = "0x4018E5A")]
		None,
		// Token: 0x0400090A RID: 2314
		[Token(Token = "0x4018E5B")]
		Start,
		// Token: 0x0400090B RID: 2315
		[Token(Token = "0x4018E5C")]
		StartLanding,
		// Token: 0x0400090C RID: 2316
		[Token(Token = "0x4018E5D")]
		Landing,
		// Token: 0x0400090D RID: 2317
		[Token(Token = "0x4018E5E")]
		End,
		// Token: 0x0400090E RID: 2318
		[Token(Token = "0x4018E5F")]
		Error
	}

	// Token: 0x0200027C RID: 636
	[Token(Token = "0x200100C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1572C0", Offset = "0x1573C1")]
	private sealed class <>c__DisplayClass10_0
	{
		// Token: 0x06000FE8 RID: 4072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C76")]
		[Address(RVA = "0x1DAE480", Offset = "0x1DAE581", VA = "0x1DAE480")]
		public <>c__DisplayClass10_0()
		{
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C77")]
		[Address(RVA = "0x1DAE750", Offset = "0x1DAE851", VA = "0x1DAE750")]
		internal void <DoStart>b__0()
		{
		}

		// Token: 0x0400090F RID: 2319
		[Token(Token = "0x4018E60")]
		[FieldOffset(Offset = "0x10")]
		public WarpPoints.WarpPoint warpPoint;

		// Token: 0x04000910 RID: 2320
		[Token(Token = "0x4018E61")]
		[FieldOffset(Offset = "0x90")]
		public string sceneName;

		// Token: 0x04000911 RID: 2321
		[Token(Token = "0x4018E62")]
		[FieldOffset(Offset = "0x98")]
		public EscapeManager <>4__this;
	}
}
