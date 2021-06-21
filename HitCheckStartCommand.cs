using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000C8 RID: 200
[Token(Token = "0x200009E")]
public class HitCheckStartCommand : ToolActionCommandBase
{
	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B6")]
	public string NextActionCode1
	{
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x24F5000", Offset = "0x24F5101", VA = "0x24F5000")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x060003CC RID: 972 RVA: 0x000033D8 File Offset: 0x000015D8
	[Token(Token = "0x170000B7")]
	public bool IsAttackHit
	{
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x24F5020", Offset = "0x24F5121", VA = "0x24F5020")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x060003CD RID: 973 RVA: 0x000033F0 File Offset: 0x000015F0
	[Token(Token = "0x170000B8")]
	public Vector3 Offset
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x24F5040", Offset = "0x24F5141", VA = "0x24F5040")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060003CE RID: 974 RVA: 0x00003408 File Offset: 0x00001608
	[Token(Token = "0x170000B9")]
	public float Radius
	{
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x24F5060", Offset = "0x24F5161", VA = "0x24F5060")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000311")]
	[Address(RVA = "0x24F5080", Offset = "0x24F5181", VA = "0x24F5080")]
	public HitCheckStartCommand(ActionCommandDataTable actionCommandData, AS_ToolController controller)
	{
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000312")]
	[Address(RVA = "0x24F5110", Offset = "0x24F5211", VA = "0x24F5110", Slot = "8")]
	public override void DoAction()
	{
	}
}
