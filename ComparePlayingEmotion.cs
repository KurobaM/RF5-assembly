using System;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

// Token: 0x0200014C RID: 332
[Token(Token = "0x2000100")]
public class ComparePlayingEmotion : Conditional
{
	// Token: 0x1700017D RID: 381
	// (get) Token: 0x06000712 RID: 1810 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000169")]
	private Character Character
	{
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x20DCC00", Offset = "0x20DCD01", VA = "0x20DCC00")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F2")]
	[Address(RVA = "0x20DCC20", Offset = "0x20DCD21", VA = "0x20DCC20", Slot = "4")]
	public override void OnAwake()
	{
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00004830 File Offset: 0x00002A30
	[Token(Token = "0x60005F3")]
	[Address(RVA = "0x20DCC90", Offset = "0x20DCD91", VA = "0x20DCC90", Slot = "6")]
	public override TaskStatus OnUpdate()
	{
		return TaskStatus.Inactive;
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F4")]
	[Address(RVA = "0x20DCD20", Offset = "0x20DCE21", VA = "0x20DCD20")]
	public ComparePlayingEmotion()
	{
	}

	// Token: 0x04000408 RID: 1032
	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x50")]
	private AIInput AIInput;

	// Token: 0x04000409 RID: 1033
	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x58")]
	public SharedBool CompareValue;
}
