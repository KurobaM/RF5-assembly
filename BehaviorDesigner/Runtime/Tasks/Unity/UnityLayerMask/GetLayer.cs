using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLayerMask
{
	// Token: 0x02001435 RID: 5173
	[Token(Token = "0x2000DFB")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x152F30", Offset = "0x153031")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x152F30", Offset = "0x153031")]
	public class GetLayer : Action
	{
		// Token: 0x06007743 RID: 30531 RVA: 0x00029700 File Offset: 0x00027900
		[Token(Token = "0x60063F7")]
		[Address(RVA = "0x28E6A90", Offset = "0x28E6B91", VA = "0x28E6A90", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F8")]
		[Address(RVA = "0x28E6B40", Offset = "0x28E6C41", VA = "0x28E6B40", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F9")]
		[Address(RVA = "0x28E6BB0", Offset = "0x28E6CB1", VA = "0x28E6BB0")]
		public GetLayer()
		{
		}

		// Token: 0x0401BA25 RID: 113189
		[Token(Token = "0x4018423")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EE80", Offset = "0x18EF81")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401BA26 RID: 113190
		[Token(Token = "0x4018424")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18EEC0", Offset = "0x18EFC1")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18EEC0", Offset = "0x18EFC1")]
		public SharedString storeResult;
	}
}
