using System;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace DG.Tweening
{
	// Token: 0x02001646 RID: 5702
	[Token(Token = "0x2000F83")]
	public static class DOTweenModuleUtils
	{
		// Token: 0x0600815A RID: 33114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ACF")]
		[Address(RVA = "0x1D9CEC0", Offset = "0x1D9CFC1", VA = "0x1D9CEC0")]
		[Attribute(Name = "PreserveAttribute", RVA = "0x1AFB40", Offset = "0x1AFC41")]
		public static void Init()
		{
		}

		// Token: 0x0600815B RID: 33115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD0")]
		[Address(RVA = "0x1D9CF70", Offset = "0x1D9D071", VA = "0x1D9CF70")]
		[Attribute(Name = "PreserveAttribute", RVA = "0x1AFB50", Offset = "0x1AFC51")]
		private static void Preserver()
		{
		}

		// Token: 0x0401C209 RID: 115209
		[Token(Token = "0x40189D9")]
		[FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		// Token: 0x02001647 RID: 5703
		[Token(Token = "0x2001614")]
		public static class Physics
		{
			// Token: 0x0600815C RID: 33116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6008098")]
			[Address(RVA = "0x1D9D010", Offset = "0x1D9D111", VA = "0x1D9D010")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			// Token: 0x0600815D RID: 33117 RVA: 0x0002E890 File Offset: 0x0002CA90
			[Token(Token = "0x6008099")]
			[Address(RVA = "0x1D9D120", Offset = "0x1D9D221", VA = "0x1D9D120")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			// Token: 0x0600815E RID: 33118 RVA: 0x0002E8A8 File Offset: 0x0002CAA8
			[Token(Token = "0x600809A")]
			[Address(RVA = "0x1D9D1B0", Offset = "0x1D9D2B1", VA = "0x1D9D1B0")]
			[Attribute(Name = "PreserveAttribute", RVA = "0x1B7340", Offset = "0x1B7441")]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			// Token: 0x0600815F RID: 33119 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600809B")]
			[Address(RVA = "0x1D9D240", Offset = "0x1D9D341", VA = "0x1D9D240")]
			[Attribute(Name = "PreserveAttribute", RVA = "0x1B7350", Offset = "0x1B7451")]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}
	}
}
