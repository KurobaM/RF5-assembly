using System;
using Il2CppDummyDll;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityVector3
{
	// Token: 0x02001313 RID: 4883
	[Token(Token = "0x2000CDF")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x14C460", Offset = "0x14C561")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x14C460", Offset = "0x14C561")]
	public class SetValue : Action
	{
		// Token: 0x06007347 RID: 29511 RVA: 0x00027C60 File Offset: 0x00025E60
		[Token(Token = "0x6005FFB")]
		[Address(RVA = "0x244B1D0", Offset = "0x244B2D1", VA = "0x244B1D0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFC")]
		[Address(RVA = "0x244B250", Offset = "0x244B351", VA = "0x244B250", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFD")]
		[Address(RVA = "0x244B2F0", Offset = "0x244B3F1", VA = "0x244B2F0")]
		public SetValue()
		{
		}

		// Token: 0x0401B632 RID: 112178
		[Token(Token = "0x4018057")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1847E0", Offset = "0x1848E1")]
		public SharedVector3 vector3Value;

		// Token: 0x0401B633 RID: 112179
		[Token(Token = "0x4018058")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x184820", Offset = "0x184921")]
		public SharedVector3 vector3Variable;
	}
}
