using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;

namespace Funly.SkyStudio
{
	// Token: 0x02000E05 RID: 3589
	[Token(Token = "0x200092C")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x148D70", Offset = "0x148E71")]
	public class FollowCamera : MonoBehaviour
	{
		// Token: 0x06005D5A RID: 23898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D71")]
		[Address(RVA = "0x23D5570", Offset = "0x23D5671", VA = "0x23D5570")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005D5B RID: 23899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D72")]
		[Address(RVA = "0x23D5670", Offset = "0x23D5771", VA = "0x23D5670")]
		private void Start()
		{
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D73")]
		[Address(RVA = "0x23D5820", Offset = "0x23D5921", VA = "0x23D5820")]
		private void OnChangeActiveCamara(Camera camera)
		{
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D74")]
		[Address(RVA = "0x23D5AD0", Offset = "0x23D5BD1", VA = "0x23D5AD0")]
		public FollowCamera()
		{
		}

		// Token: 0x0400BD87 RID: 48519
		[Token(Token = "0x4008DF4")]
		[FieldOffset(Offset = "0x18")]
		public Camera followCamera;

		// Token: 0x0400BD88 RID: 48520
		[Token(Token = "0x4008DF5")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		// Token: 0x0400BD89 RID: 48521
		[Token(Token = "0x4008DF6")]
		[FieldOffset(Offset = "0x30")]
		private RotationConstraint RotationConstraint;
	}
}
