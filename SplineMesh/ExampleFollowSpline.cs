using System;
using Il2CppDummyDll;
using UnityEngine;

namespace SplineMesh
{
	// Token: 0x02000E42 RID: 3650
	[Token(Token = "0x2000957")]
	[Attribute(Name = "ExecuteInEditMode", RVA = "0x1491F0", Offset = "0x1492F1")]
	[Attribute(Name = "RequireComponent", RVA = "0x1491F0", Offset = "0x1492F1")]
	public class ExampleFollowSpline : MonoBehaviour
	{
		// Token: 0x06006012 RID: 24594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F83")]
		[Address(RVA = "0x22664D0", Offset = "0x22665D1", VA = "0x22664D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06006013 RID: 24595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F84")]
		[Address(RVA = "0x2266660", Offset = "0x2266761", VA = "0x2266660")]
		private void OnDisable()
		{
		}

		// Token: 0x06006014 RID: 24596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F85")]
		[Address(RVA = "0x2266670", Offset = "0x2266771", VA = "0x2266670")]
		private void EditorUpdate()
		{
		}

		// Token: 0x06006015 RID: 24597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F86")]
		[Address(RVA = "0x2266710", Offset = "0x2266811", VA = "0x2266710")]
		private void PlaceFollower()
		{
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004F87")]
		[Address(RVA = "0x2266840", Offset = "0x2266941", VA = "0x2266840")]
		public ExampleFollowSpline()
		{
		}

		// Token: 0x0400BF0B RID: 48907
		[Token(Token = "0x4008EE6")]
		[FieldOffset(Offset = "0x18")]
		private GameObject generated;

		// Token: 0x0400BF0C RID: 48908
		[Token(Token = "0x4008EE7")]
		[FieldOffset(Offset = "0x20")]
		private Spline spline;

		// Token: 0x0400BF0D RID: 48909
		[Token(Token = "0x4008EE8")]
		[FieldOffset(Offset = "0x28")]
		private float rate;

		// Token: 0x0400BF0E RID: 48910
		[Token(Token = "0x4008EE9")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Follower;

		// Token: 0x0400BF0F RID: 48911
		[Token(Token = "0x4008EEA")]
		[FieldOffset(Offset = "0x38")]
		public float DurationInSecond;
	}
}
