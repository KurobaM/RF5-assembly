using System;
using Il2CppDummyDll;
using UnityEngine;

namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityParticleSystem
{
	// Token: 0x020013E7 RID: 5095
	[Token(Token = "0x2000DB2")]
	[Attribute(Name = "TaskCategoryAttribute", RVA = "0x1513D0", Offset = "0x1514D1")]
	[Attribute(Name = "TaskDescriptionAttribute", RVA = "0x1513D0", Offset = "0x1514D1")]
	public class IsStopped : Conditional
	{
		// Token: 0x06007635 RID: 30261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E9")]
		[Address(RVA = "0x2989A10", Offset = "0x2989B11", VA = "0x2989A10", Slot = "5")]
		public override void OnStart()
		{
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00029028 File Offset: 0x00027228
		[Token(Token = "0x60062EA")]
		[Address(RVA = "0x2989B10", Offset = "0x2989C11", VA = "0x2989B10", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return TaskStatus.Inactive;
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062EB")]
		[Address(RVA = "0x2989BF0", Offset = "0x2989CF1", VA = "0x2989BF0", Slot = "16")]
		public override void OnReset()
		{
		}

		// Token: 0x06007638 RID: 30264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062EC")]
		[Address(RVA = "0x2989C00", Offset = "0x2989D01", VA = "0x2989C00")]
		public IsStopped()
		{
		}

		// Token: 0x0401B904 RID: 112900
		[Token(Token = "0x4018325")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x18C7F0", Offset = "0x18C8F1")]
		public SharedGameObject targetGameObject;

		// Token: 0x0401B905 RID: 112901
		[Token(Token = "0x4018326")]
		[FieldOffset(Offset = "0x58")]
		private ParticleSystem particleSystem;

		// Token: 0x0401B906 RID: 112902
		[Token(Token = "0x4018327")]
		[FieldOffset(Offset = "0x60")]
		private GameObject prevGameObject;
	}
}
