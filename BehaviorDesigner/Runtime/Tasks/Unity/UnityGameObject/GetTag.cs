using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x0200144E RID: 5198
	[Token(Token = "0x2000E14")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153890", Offset = "0x153991")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153890", Offset = "0x153991")]
	public class GetTag : Action
	{
		// Token: 0x0600778E RID: 30606 RVA: 0x00029958 File Offset: 0x00027B58
		[Token(Token = "0x6006442")]
		[Address(RVA = "0x28E5760", Offset = "0x28E5861", VA = "0x28E5760", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006443")]
		[Address(RVA = "0x28E5800", Offset = "0x28E5901", VA = "0x28E5800", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007790 RID: 30608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006444")]
		[Address(RVA = "0x28E5870", Offset = "0x28E5971", VA = "0x28E5870")]
		public GetTag()
		{
		}

		// Token: 0x0401BA50 RID: 113232
		[Token(Token = "0x401844E")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FA00", Offset = "0x18FB01")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA51 RID: 113233
		[Token(Token = "0x401844F")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18FA40", Offset = "0x18FB41")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18FA40", Offset = "0x18FB41")]
		public SharedString storeValue;
	}
}
