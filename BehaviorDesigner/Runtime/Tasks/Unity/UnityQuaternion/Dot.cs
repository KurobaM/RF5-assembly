using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	// Token: 0x020013C2 RID: 5058
	[Token(Token = "0x2000D8D")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1505F0", Offset = "0x1506F1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1505F0", Offset = "0x1506F1")]
	public class Dot : Action
	{
		// Token: 0x060075BC RID: 30140 RVA: 0x00028CB0 File Offset: 0x00026EB0
		[Token(Token = "0x6006270")]
		[Address(RVA = "0x298E660", Offset = "0x298E761", VA = "0x298E660", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075BD RID: 30141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006271")]
		[Address(RVA = "0x298E780", Offset = "0x298E881", VA = "0x298E780", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006272")]
		[Address(RVA = "0x298E830", Offset = "0x298E931", VA = "0x298E830")]
		public Dot()
		{
		}

		// Token: 0x0401B87D RID: 112765
		[Token(Token = "0x401829E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A9F0", Offset = "0x18AAF1")]
		public SharedQuaternion leftRotation;

		// Token: 0x0401B87E RID: 112766
		[Token(Token = "0x401829F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AA30", Offset = "0x18AB31")]
		public SharedQuaternion rightRotation;

		// Token: 0x0401B87F RID: 112767
		[Token(Token = "0x40182A0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AA70", Offset = "0x18AB71")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18AA70", Offset = "0x18AB71")]
		public SharedFloat storeResult;
	}
}
