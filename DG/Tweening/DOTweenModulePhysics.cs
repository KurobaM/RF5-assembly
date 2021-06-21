using System;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x020015FD RID: 5629
	[Token(Token = "0x2000F7D")]
	public static class DOTweenModulePhysics
	{
		// Token: 0x06008054 RID: 32852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A89")]
		[Address(RVA = "0x20EFA40", Offset = "0x20EFB41", VA = "0x20EFA40")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		// Token: 0x06008055 RID: 32853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8A")]
		[Address(RVA = "0x20EFBD0", Offset = "0x20EFCD1", VA = "0x20EFBD0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8B")]
		[Address(RVA = "0x20EFD80", Offset = "0x20EFE81", VA = "0x20EFD80")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		// Token: 0x06008057 RID: 32855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8C")]
		[Address(RVA = "0x20EFF30", Offset = "0x20F0031", VA = "0x20EFF30")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		// Token: 0x06008058 RID: 32856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8D")]
		[Address(RVA = "0x20F00E0", Offset = "0x20F01E1", VA = "0x20F00E0")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		// Token: 0x06008059 RID: 32857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8E")]
		[Address(RVA = "0x20F0270", Offset = "0x20F0371", VA = "0x20F0270")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		// Token: 0x0600805A RID: 32858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8F")]
		[Address(RVA = "0x20F0480", Offset = "0x20F0581", VA = "0x20F0480")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		// Token: 0x0600805B RID: 32859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A90")]
		[Address(RVA = "0x20F0940", Offset = "0x20F0A41", VA = "0x20F0940")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A91")]
		[Address(RVA = "0x20F0B50", Offset = "0x20F0C51", VA = "0x20F0B50")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		// Token: 0x0600805D RID: 32861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A92")]
		[Address(RVA = "0x20F0D80", Offset = "0x20F0E81", VA = "0x20F0D80")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A93")]
		[Address(RVA = "0x20F0F10", Offset = "0x20F1011", VA = "0x20F0F10")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		// Token: 0x020015FE RID: 5630
		[Token(Token = "0x20015D1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AA30", Offset = "0x15AB31")]
		private sealed class <>c__DisplayClass0_0
		{
			// Token: 0x0600805F RID: 32863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FD8")]
			[Address(RVA = "0x20EFBC0", Offset = "0x20EFCC1", VA = "0x20EFBC0")]
			public <>c__DisplayClass0_0()
			{
			}

			// Token: 0x06008060 RID: 32864 RVA: 0x0002E200 File Offset: 0x0002C400
			[Token(Token = "0x6007FD9")]
			[Address(RVA = "0x20F10D0", Offset = "0x20F11D1", VA = "0x20F10D0")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}

			// Token: 0x0401C1AC RID: 115116
			[Token(Token = "0x401C38E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;
		}

		// Token: 0x020015FF RID: 5631
		[Token(Token = "0x20015D2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AA40", Offset = "0x15AB41")]
		private sealed class <>c__DisplayClass1_0
		{
			// Token: 0x06008061 RID: 32865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FDA")]
			[Address(RVA = "0x20EFD70", Offset = "0x20EFE71", VA = "0x20EFD70")]
			public <>c__DisplayClass1_0()
			{
			}

			// Token: 0x06008062 RID: 32866 RVA: 0x0002E218 File Offset: 0x0002C418
			[Token(Token = "0x6007FDB")]
			[Address(RVA = "0x20F1210", Offset = "0x20F1311", VA = "0x20F1210")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}

			// Token: 0x0401C1AD RID: 115117
			[Token(Token = "0x401C38F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;
		}

		// Token: 0x02001600 RID: 5632
		[Token(Token = "0x20015D3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AA50", Offset = "0x15AB51")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06008063 RID: 32867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FDC")]
			[Address(RVA = "0x20EFF20", Offset = "0x20F0021", VA = "0x20EFF20")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x06008064 RID: 32868 RVA: 0x0002E230 File Offset: 0x0002C430
			[Token(Token = "0x6007FDD")]
			[Address(RVA = "0x20F1230", Offset = "0x20F1331", VA = "0x20F1230")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}

			// Token: 0x0401C1AE RID: 115118
			[Token(Token = "0x401C390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;
		}

		// Token: 0x02001601 RID: 5633
		[Token(Token = "0x20015D4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AA60", Offset = "0x15AB61")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x06008065 RID: 32869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FDE")]
			[Address(RVA = "0x20F00D0", Offset = "0x20F01D1", VA = "0x20F00D0")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x06008066 RID: 32870 RVA: 0x0002E248 File Offset: 0x0002C448
			[Token(Token = "0x6007FDF")]
			[Address(RVA = "0x20F1250", Offset = "0x20F1351", VA = "0x20F1250")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}

			// Token: 0x0401C1AF RID: 115119
			[Token(Token = "0x401C391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;
		}

		// Token: 0x02001602 RID: 5634
		[Token(Token = "0x20015D5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AA70", Offset = "0x15AB71")]
		private sealed class <>c__DisplayClass4_0
		{
			// Token: 0x06008067 RID: 32871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FE0")]
			[Address(RVA = "0x20F0260", Offset = "0x20F0361", VA = "0x20F0260")]
			public <>c__DisplayClass4_0()
			{
			}

			// Token: 0x06008068 RID: 32872 RVA: 0x0002E260 File Offset: 0x0002C460
			[Token(Token = "0x6007FE1")]
			[Address(RVA = "0x20F1270", Offset = "0x20F1371", VA = "0x20F1270")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}

			// Token: 0x0401C1B0 RID: 115120
			[Token(Token = "0x401C392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;
		}

		// Token: 0x02001603 RID: 5635
		[Token(Token = "0x20015D6")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AA80", Offset = "0x15AB81")]
		private sealed class <>c__DisplayClass5_0
		{
			// Token: 0x06008069 RID: 32873 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FE2")]
			[Address(RVA = "0x20F0470", Offset = "0x20F0571", VA = "0x20F0470")]
			public <>c__DisplayClass5_0()
			{
			}

			// Token: 0x0600806A RID: 32874 RVA: 0x0002E278 File Offset: 0x0002C478
			[Token(Token = "0x6007FE3")]
			[Address(RVA = "0x20F1290", Offset = "0x20F1391", VA = "0x20F1290")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}

			// Token: 0x0401C1B1 RID: 115121
			[Token(Token = "0x401C393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;
		}

		// Token: 0x02001604 RID: 5636
		[Token(Token = "0x20015D7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AA90", Offset = "0x15AB91")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x0600806B RID: 32875 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FE4")]
			[Address(RVA = "0x20F0930", Offset = "0x20F0A31", VA = "0x20F0930")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x0600806C RID: 32876 RVA: 0x0002E290 File Offset: 0x0002C490
			[Token(Token = "0x6007FE5")]
			[Address(RVA = "0x20F12B0", Offset = "0x20F13B1", VA = "0x20F12B0")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			// Token: 0x0600806D RID: 32877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FE6")]
			[Address(RVA = "0x20F12D0", Offset = "0x20F13D1", VA = "0x20F12D0")]
			internal void <DOJump>b__1()
			{
			}

			// Token: 0x0600806E RID: 32878 RVA: 0x0002E2A8 File Offset: 0x0002C4A8
			[Token(Token = "0x6007FE7")]
			[Address(RVA = "0x20F1310", Offset = "0x20F1411", VA = "0x20F1310")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			// Token: 0x0600806F RID: 32879 RVA: 0x0002E2C0 File Offset: 0x0002C4C0
			[Token(Token = "0x6007FE8")]
			[Address(RVA = "0x20F1330", Offset = "0x20F1431", VA = "0x20F1330")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			// Token: 0x06008070 RID: 32880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FE9")]
			[Address(RVA = "0x20F1350", Offset = "0x20F1451", VA = "0x20F1350")]
			internal void <DOJump>b__4()
			{
			}

			// Token: 0x0401C1B2 RID: 115122
			[Token(Token = "0x401C394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			// Token: 0x0401C1B3 RID: 115123
			[Token(Token = "0x401C395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			// Token: 0x0401C1B4 RID: 115124
			[Token(Token = "0x401C396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			// Token: 0x0401C1B5 RID: 115125
			[Token(Token = "0x401C397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			// Token: 0x0401C1B6 RID: 115126
			[Token(Token = "0x401C398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			// Token: 0x0401C1B7 RID: 115127
			[Token(Token = "0x401C399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			// Token: 0x0401C1B8 RID: 115128
			[Token(Token = "0x401C39A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;
		}

		// Token: 0x02001605 RID: 5637
		[Token(Token = "0x20015D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AAA0", Offset = "0x15ABA1")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x06008071 RID: 32881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FEA")]
			[Address(RVA = "0x20F0B40", Offset = "0x20F0C41", VA = "0x20F0B40")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x06008072 RID: 32882 RVA: 0x0002E2D8 File Offset: 0x0002C4D8
			[Token(Token = "0x6007FEB")]
			[Address(RVA = "0x20F1410", Offset = "0x20F1511", VA = "0x20F1410")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			// Token: 0x0401C1B9 RID: 115129
			[Token(Token = "0x401C39B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;
		}

		// Token: 0x02001606 RID: 5638
		[Token(Token = "0x20015D9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AAB0", Offset = "0x15ABB1")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x06008073 RID: 32883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FEC")]
			[Address(RVA = "0x20F0D70", Offset = "0x20F0E71", VA = "0x20F0D70")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06008074 RID: 32884 RVA: 0x0002E2F0 File Offset: 0x0002C4F0
			[Token(Token = "0x6007FED")]
			[Address(RVA = "0x20F1430", Offset = "0x20F1531", VA = "0x20F1430")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			// Token: 0x06008075 RID: 32885 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FEE")]
			[Address(RVA = "0x20F1450", Offset = "0x20F1551", VA = "0x20F1450")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}

			// Token: 0x0401C1BA RID: 115130
			[Token(Token = "0x401C39C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			// Token: 0x0401C1BB RID: 115131
			[Token(Token = "0x401C39D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;
		}

		// Token: 0x02001607 RID: 5639
		[Token(Token = "0x20015DA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AAC0", Offset = "0x15ABC1")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06008076 RID: 32886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FEF")]
			[Address(RVA = "0x1D95020", Offset = "0x1D95121", VA = "0x1D95020")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06008077 RID: 32887 RVA: 0x0002E308 File Offset: 0x0002C508
			[Token(Token = "0x6007FF0")]
			[Address(RVA = "0x1D95030", Offset = "0x1D95131", VA = "0x1D95030")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}

			// Token: 0x0401C1BC RID: 115132
			[Token(Token = "0x401C39E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;
		}

		// Token: 0x02001608 RID: 5640
		[Token(Token = "0x20015DB")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15AAD0", Offset = "0x15ABD1")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x06008078 RID: 32888 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FF1")]
			[Address(RVA = "0x20F10C0", Offset = "0x20F11C1", VA = "0x20F10C0")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x06008079 RID: 32889 RVA: 0x0002E320 File Offset: 0x0002C520
			[Token(Token = "0x6007FF2")]
			[Address(RVA = "0x20F10F0", Offset = "0x20F11F1", VA = "0x20F10F0")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			// Token: 0x0600807A RID: 32890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007FF3")]
			[Address(RVA = "0x20F1110", Offset = "0x20F1211", VA = "0x20F1110")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}

			// Token: 0x0401C1BD RID: 115133
			[Token(Token = "0x401C39F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			// Token: 0x0401C1BE RID: 115134
			[Token(Token = "0x401C3A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;
		}
	}
}
