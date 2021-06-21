using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityQuaternion
{
	// Token: 0x020013C7 RID: 5063
	[Token(Token = "0x2000D92")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1507D0", Offset = "0x1508D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1507D0", Offset = "0x1508D1")]
	public class Lerp : Action
	{
		// Token: 0x060075CB RID: 30155 RVA: 0x00028D28 File Offset: 0x00026F28
		[Token(Token = "0x600627F")]
		[Address(RVA = "0x298EE70", Offset = "0x298EF71", VA = "0x298EE70", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006280")]
		[Address(RVA = "0x298EFC0", Offset = "0x298F0C1", VA = "0x298EFC0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006281")]
		[Address(RVA = "0x298F080", Offset = "0x298F181", VA = "0x298F080")]
		public Lerp()
		{
		}

		// Token: 0x0401B888 RID: 112776
		[Token(Token = "0x40182A9")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AD00", Offset = "0x18AE01")]
		public SharedQuaternion fromQuaternion;

		// Token: 0x0401B889 RID: 112777
		[Token(Token = "0x40182AA")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AD40", Offset = "0x18AE41")]
		public SharedQuaternion toQuaternion;

		// Token: 0x0401B88A RID: 112778
		[Token(Token = "0x40182AB")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18AD80", Offset = "0x18AE81")]
		public SharedFloat amount;

		// Token: 0x0401B88B RID: 112779
		[Token(Token = "0x40182AC")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18ADC0", Offset = "0x18AEC1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18ADC0", Offset = "0x18AEC1")]
		public SharedQuaternion storeResult;
	}
}
