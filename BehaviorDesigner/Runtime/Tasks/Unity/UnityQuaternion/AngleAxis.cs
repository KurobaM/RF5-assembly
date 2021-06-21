using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	// Token: 0x020013C1 RID: 5057
	[Token(Token = "0x2000D8C")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x150590", Offset = "0x150691")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x150590", Offset = "0x150691")]
	public class AngleAxis : Action
	{
		// Token: 0x060075B9 RID: 30137 RVA: 0x00028C98 File Offset: 0x00026E98
		[Token(Token = "0x600626D")]
		[Address(RVA = "0x298E480", Offset = "0x298E581", VA = "0x298E480", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075BA RID: 30138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626E")]
		[Address(RVA = "0x298E570", Offset = "0x298E671", VA = "0x298E570", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075BB RID: 30139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600626F")]
		[Address(RVA = "0x298E650", Offset = "0x298E751", VA = "0x298E650")]
		public AngleAxis()
		{
		}

		// Token: 0x0401B87A RID: 112762
		[Token(Token = "0x401829B")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A920", Offset = "0x18AA21")]
		public SharedFloat degrees;

		// Token: 0x0401B87B RID: 112763
		[Token(Token = "0x401829C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A960", Offset = "0x18AA61")]
		public SharedVector3 axis;

		// Token: 0x0401B87C RID: 112764
		[Token(Token = "0x401829D")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18A9A0", Offset = "0x18AAA1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18A9A0", Offset = "0x18AAA1")]
		public SharedQuaternion storeResult;
	}
}
