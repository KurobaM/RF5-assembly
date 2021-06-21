using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityBehaviour
{
	// Token: 0x0200147C RID: 5244
	[Token(Token = "0x2000E42")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1549D0", Offset = "0x154AD1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1549D0", Offset = "0x154AD1")]
	public class SetEnabled : Action
	{
		// Token: 0x0600783C RID: 30780 RVA: 0x00029DC0 File Offset: 0x00027FC0
		[Token(Token = "0x60064F0")]
		[Address(RVA = "0x28DEFB0", Offset = "0x28DF0B1", VA = "0x28DEFB0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F1")]
		[Address(RVA = "0x28DF090", Offset = "0x28DF191", VA = "0x28DF090", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x0600783E RID: 30782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064F2")]
		[Address(RVA = "0x28DF110", Offset = "0x28DF211", VA = "0x28DF110")]
		public SetEnabled()
		{
		}

		// Token: 0x0401BAF6 RID: 113398
		[Token(Token = "0x40184F4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x191370", Offset = "0x191471")]
		public SharedBehaviour specifiedObject;

		// Token: 0x0401BAF7 RID: 113399
		[Token(Token = "0x40184F5")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1913B0", Offset = "0x1914B1")]
		public SharedBool enabled;
	}
}
