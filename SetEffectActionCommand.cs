using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020000DD RID: 221
[Token(Token = "0x20000B3")]
public class SetEffectActionCommand : ActionCommandBase
{
	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06000432 RID: 1074 RVA: 0x00003888 File Offset: 0x00001A88
	[Token(Token = "0x170000ED")]
	public EffectID UseEffectID
	{
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1E33A90", Offset = "0x1E33B91", VA = "0x1E33A90")]
		get
		{
			return EffectID.EFFECT_EMPTY;
		}
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000433 RID: 1075 RVA: 0x000038A0 File Offset: 0x00001AA0
	[Token(Token = "0x170000EE")]
	public bool IsAutoDestroy
	{
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1E33B80", Offset = "0x1E33C81", VA = "0x1E33B80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000434 RID: 1076 RVA: 0x000038B8 File Offset: 0x00001AB8
	[Token(Token = "0x170000EF")]
	public bool IsAttach
	{
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1E33BB0", Offset = "0x1E33CB1", VA = "0x1E33BB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x06000435 RID: 1077 RVA: 0x000038D0 File Offset: 0x00001AD0
	[Token(Token = "0x170000F0")]
	public Vector3 Position
	{
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1E33BE0", Offset = "0x1E33CE1", VA = "0x1E33BE0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000436 RID: 1078 RVA: 0x000038E8 File Offset: 0x00001AE8
	[Token(Token = "0x170000F1")]
	public Vector3 Rotation
	{
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1E33C00", Offset = "0x1E33D01", VA = "0x1E33C00")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000438 RID: 1080 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F2")]
	private ParticleDestroy ParticleDestroy
	{
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1E33C20", Offset = "0x1E33D21", VA = "0x1E33C20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A160", Offset = "0x19A261")]
		get
		{
			return null;
		}
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1E33C30", Offset = "0x1E33D31", VA = "0x1E33C30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A170", Offset = "0x19A271")]
		set
		{
		}
	}

	// Token: 0x06000439 RID: 1081 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037B")]
	[Address(RVA = "0x1E33C40", Offset = "0x1E33D41", VA = "0x1E33C40")]
	public SetEffectActionCommand(ActionCommandDataTable actionCommandData, ActionScriptControllerBase controller)
	{
	}

	// Token: 0x0600043A RID: 1082 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x1E33DC0", Offset = "0x1E33EC1", VA = "0x1E33DC0", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x0600043B RID: 1083 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037D")]
	[Address(RVA = "0x1E33E90", Offset = "0x1E33F91", VA = "0x1E33E90", Slot = "11")]
	public override void ActionFinal()
	{
	}

	// Token: 0x0600043C RID: 1084 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037E")]
	[Address(RVA = "0x1E33F30", Offset = "0x1E34031", VA = "0x1E33F30")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19A180", Offset = "0x19A281")]
	private void <DoAction>b__15_0(ParticleSystem prefab)
	{
	}

	// Token: 0x04000266 RID: 614
	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x80")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15B880", Offset = "0x15B981")]
	private ParticleDestroy <ParticleDestroy>k__BackingField;

	// Token: 0x020000DE RID: 222
	[Token(Token = "0x2000FB4")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157070", Offset = "0x157171")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BAA")]
		[Address(RVA = "0x1E34370", Offset = "0x1E34471", VA = "0x1E34370")]
		public <>c()
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BAB")]
		[Address(RVA = "0x1E34380", Offset = "0x1E34481", VA = "0x1E34380")]
		internal void <.ctor>b__14_0(ParticleSystem effect)
		{
		}

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4018CFD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SetEffectActionCommand.<>c <>9;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4018CFE")]
		[FieldOffset(Offset = "0x8")]
		public static UnityAction<ParticleSystem> <>9__14_0;
	}
}
