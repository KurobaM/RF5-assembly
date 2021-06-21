using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityLight
{
	// Token: 0x02001424 RID: 5156
	[Token(Token = "0x2000DEA")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1528D0", Offset = "0x1529D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1528D0", Offset = "0x1529D1")]
	public class GetCookieSize : Action
	{
		// Token: 0x060076FF RID: 30463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B3")]
		[Address(RVA = "0x28E6FA0", Offset = "0x28E70A1", VA = "0x28E6FA0", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x00029568 File Offset: 0x00027768
		[Token(Token = "0x60063B4")]
		[Address(RVA = "0x28E70A0", Offset = "0x28E71A1", VA = "0x28E70A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B5")]
		[Address(RVA = "0x28E7190", Offset = "0x28E7291", VA = "0x28E7190", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063B6")]
		[Address(RVA = "0x28E71E0", Offset = "0x28E72E1", VA = "0x28E71E0")]
		public GetCookieSize()
		{
		}

		// Token: 0x0401B9E1 RID: 113121
		[Token(Token = "0x40183DF")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E5A0", Offset = "0x18E6A1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B9E2 RID: 113122
		[Token(Token = "0x40183E0")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "RequiredFieldAttribute", RVA = "0x18E5E0", Offset = "0x18E6E1")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18E5E0", Offset = "0x18E6E1")]
		public SharedFloat storeValue;

		// Token: 0x0401B9E3 RID: 113123
		[Token(Token = "0x40183E1")]
		[FieldOffset(Offset = "0x60")]
		private Light light;

		// Token: 0x0401B9E4 RID: 113124
		[Token(Token = "0x40183E2")]
		[FieldOffset(Offset = "0x68")]
		private GameObject prevGameObject;
	}
}
