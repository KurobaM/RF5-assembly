using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012D7 RID: 4823
	[Token(Token = "0x2000CA4")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14AD00", Offset = "0x14AE01")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14AD00", Offset = "0x14AE01")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14AD00", Offset = "0x14AE01")]
	public class GetFieldValue : Action
	{
		// Token: 0x0600721E RID: 29214 RVA: 0x000273C0 File Offset: 0x000255C0
		[Token(Token = "0x6005ED2")]
		[Address(RVA = "0x22113F0", Offset = "0x22114F1", VA = "0x22113F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600721F RID: 29215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED3")]
		[Address(RVA = "0x2211670", Offset = "0x2211771", VA = "0x2211670", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007220 RID: 29216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED4")]
		[Address(RVA = "0x22116D0", Offset = "0x22117D1", VA = "0x22116D0")]
		public GetFieldValue()
		{
		}

		// Token: 0x0401B56D RID: 111981
		[Token(Token = "0x4017F96")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1824E0", Offset = "0x1825E1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B56E RID: 111982
		[Token(Token = "0x4017F97")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182520", Offset = "0x182621")]
		public SharedString componentName;

		// Token: 0x0401B56F RID: 111983
		[Token(Token = "0x4017F98")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182560", Offset = "0x182661")]
		public SharedString fieldName;

		// Token: 0x0401B570 RID: 111984
		[Token(Token = "0x4017F99")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1825A0", Offset = "0x1826A1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x1825A0", Offset = "0x1826A1")]
		public SharedVariable fieldValue;
	}
}
