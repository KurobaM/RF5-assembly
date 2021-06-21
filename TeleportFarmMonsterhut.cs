using System;
using Field;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020005A0 RID: 1440
[Token(Token = "0x2000402")]
public class TeleportFarmMonsterhut : PlayerTeleportButton
{
	// Token: 0x170005CC RID: 1484
	// (get) Token: 0x0600236C RID: 9068 RVA: 0x0000E628 File Offset: 0x0000C828
	// (set) Token: 0x0600236D RID: 9069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700049E")]
	public bool IsEnable
	{
		[Token(Token = "0x6001DB2")]
		[Address(RVA = "0x1F6A3F0", Offset = "0x1F6A4F1", VA = "0x1F6A3F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A11F0", Offset = "0x1A12F1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001DB3")]
		[Address(RVA = "0x1F6A400", Offset = "0x1F6A501", VA = "0x1F6A400")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A1200", Offset = "0x1A1301")]
		private set
		{
		}
	}

	// Token: 0x0600236E RID: 9070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB4")]
	[Address(RVA = "0x1F6A410", Offset = "0x1F6A511", VA = "0x1F6A410")]
	public new void DoInteraction(HumanController character)
	{
	}

	// Token: 0x0600236F RID: 9071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0x1F6A420", Offset = "0x1F6A521", VA = "0x1F6A420", Slot = "21")]
	protected override void Awake()
	{
	}

	// Token: 0x06002370 RID: 9072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB6")]
	[Address(RVA = "0x1F6A550", Offset = "0x1F6A651", VA = "0x1F6A550", Slot = "20")]
	protected override void OnTriggerEnter(Collider collision)
	{
	}

	// Token: 0x06002371 RID: 9073 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB7")]
	[Address(RVA = "0x1F6A560", Offset = "0x1F6A661", VA = "0x1F6A560", Slot = "23")]
	protected override void TeleportScene()
	{
	}

	// Token: 0x06002372 RID: 9074 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001DB8")]
	[Address(RVA = "0x1F6A570", Offset = "0x1F6A671", VA = "0x1F6A570")]
	public TeleportFarmMonsterhut()
	{
	}

	// Token: 0x04006B23 RID: 27427
	[Token(Token = "0x400647A")]
	[FieldOffset(Offset = "0x9C")]
	public int FarmPlaceId;

	// Token: 0x04006B24 RID: 27428
	[Token(Token = "0x400647B")]
	[FieldOffset(Offset = "0xA0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1668E0", Offset = "0x1669E1")]
	private bool <IsEnable>k__BackingField;

	// Token: 0x04006B25 RID: 27429
	[Token(Token = "0x400647C")]
	[FieldOffset(Offset = "0xA8")]
	private FieldSceneData.Data SceneData;
}
