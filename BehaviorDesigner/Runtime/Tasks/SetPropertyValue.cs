using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks
{
	// Token: 0x020012DB RID: 4827
	[Token(Token = "0x2000CA8")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14AF40", Offset = "0x14B041")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14AF40", Offset = "0x14B041")]
	[Attribute(Name = "TaskIconAttribute", RVA = "0x14AF40", Offset = "0x14B041")]
	public class SetPropertyValue : Action
	{
		// Token: 0x0600722A RID: 29226 RVA: 0x00027420 File Offset: 0x00025620
		[Token(Token = "0x6005EDE")]
		[Address(RVA = "0x221AD50", Offset = "0x221AE51", VA = "0x221AD50", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600722B RID: 29227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDF")]
		[Address(RVA = "0x221AFE0", Offset = "0x221B0E1", VA = "0x221AFE0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600722C RID: 29228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE0")]
		[Address(RVA = "0x221B040", Offset = "0x221B141", VA = "0x221B040")]
		public SetPropertyValue()
		{
		}

		// Token: 0x0401B581 RID: 112001
		[Token(Token = "0x4017FAA")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182A00", Offset = "0x182B01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B582 RID: 112002
		[Token(Token = "0x4017FAB")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182A40", Offset = "0x182B41")]
		public SharedString componentName;

		// Token: 0x0401B583 RID: 112003
		[Token(Token = "0x4017FAC")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182A80", Offset = "0x182B81")]
		public SharedString propertyName;

		// Token: 0x0401B584 RID: 112004
		[Token(Token = "0x4017FAD")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x182AC0", Offset = "0x182BC1")]
		public SharedVariable propertyValue;
	}
}
