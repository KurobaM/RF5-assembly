using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityGameObject
{
	// Token: 0x02001445 RID: 5189
	[Token(Token = "0x2000E0B")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x153530", Offset = "0x153631")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x153530", Offset = "0x153631")]
	public class ActiveSelf : Conditional
	{
		// Token: 0x06007773 RID: 30579 RVA: 0x00029880 File Offset: 0x00027A80
		[Token(Token = "0x6006427")]
		[Address(RVA = "0x28E4CA0", Offset = "0x28E4DA1", VA = "0x28E4CA0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006428")]
		[Address(RVA = "0x28E4D30", Offset = "0x28E4E31", VA = "0x28E4D30", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006429")]
		[Address(RVA = "0x28E4D40", Offset = "0x28E4E41", VA = "0x28E4D40")]
		public ActiveSelf()
		{
		}

		// Token: 0x0401BA3E RID: 113214
		[Token(Token = "0x401843C")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18F540", Offset = "0x18F641")]
		public SharedGameObject targetGameObject;
	}
}
