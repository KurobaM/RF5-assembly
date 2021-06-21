using System;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x02000121 RID: 289
[Token(Token = "0x20000E5")]
public class IsChangePartnerMovementOaderType : Conditional
{
	// Token: 0x17000161 RID: 353
	// (get) Token: 0x06000628 RID: 1576 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700015B")]
	private PartnerMovementController PartnerMovementController
	{
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x2235840", Offset = "0x2235941", VA = "0x2235840")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000545")]
	[Address(RVA = "0x2235930", Offset = "0x2235A31", VA = "0x2235930", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x000043C8 File Offset: 0x000025C8
	[Token(Token = "0x6000546")]
	[Address(RVA = "0x2235A00", Offset = "0x2235B01", VA = "0x2235A00", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000547")]
	[Address(RVA = "0x2235AE0", Offset = "0x2235BE1", VA = "0x2235AE0")]
	public IsChangePartnerMovementOaderType()
	{
	}

	// Token: 0x0400036B RID: 875
	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x50")]
	private AIInput AIInput;
}
