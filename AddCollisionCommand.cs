using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000B1 RID: 177
[Token(Token = "0x2000089")]
public class AddCollisionCommand : MonsterProjectileActionCommandBase
{
	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000099")]
	public string CollisionName
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1D568F0", Offset = "0x1D569F1", VA = "0x1D568F0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000372 RID: 882 RVA: 0x00003198 File Offset: 0x00001398
	[Token(Token = "0x1700009A")]
	public int Axis
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x1D56910", Offset = "0x1D56A11", VA = "0x1D56910")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000373 RID: 883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x1D569B0", Offset = "0x1D56AB1", VA = "0x1D569B0")]
	public AddCollisionCommand(ActionCommandDataTable actionCommandData, MonsterProjectileActionScriptsController controller)
	{
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x1D56A10", Offset = "0x1D56B11", VA = "0x1D56A10", Slot = "8")]
	public override void DoAction()
	{
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x1D56A50", Offset = "0x1D56B51", VA = "0x1D56A50")]
	public void SetupCollider(GameObject projectile)
	{
	}
}
