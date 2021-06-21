using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

// Token: 0x02000306 RID: 774
[Token(Token = "0x2000251")]
public class SceneTransitionManager : MonoBehaviour
{
	// Token: 0x17000394 RID: 916
	// (get) Token: 0x06001467 RID: 5223 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000352")]
	private static SceneTransitionManager Outer
	{
		[Token(Token = "0x6001263")]
		[Address(RVA = "0x21D4D60", Offset = "0x21D4E61", VA = "0x21D4D60")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000395 RID: 917
	// (get) Token: 0x06001468 RID: 5224 RVA: 0x00009210 File Offset: 0x00007410
	// (set) Token: 0x06001469 RID: 5225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000353")]
	public static bool IsRemoveComplete
	{
		[Token(Token = "0x6001264")]
		[Address(RVA = "0x21D4EA0", Offset = "0x21D4FA1", VA = "0x21D4EA0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CDB0", Offset = "0x19CEB1")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001265")]
		[Address(RVA = "0x21D4F10", Offset = "0x21D5011", VA = "0x21D4F10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19CDC0", Offset = "0x19CEC1")]
		private set
		{
		}
	}

	// Token: 0x17000396 RID: 918
	// (get) Token: 0x0600146A RID: 5226 RVA: 0x00009228 File Offset: 0x00007428
	[Token(Token = "0x17000354")]
	public static bool IsCreatedNaviMeshSurfaces
	{
		[Token(Token = "0x6001266")]
		[Address(RVA = "0x21D4F80", Offset = "0x21D5081", VA = "0x21D4F80")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000397 RID: 919
	// (get) Token: 0x0600146B RID: 5227 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000355")]
	public static Stack<string> SceneNameStack
	{
		[Token(Token = "0x6001267")]
		[Address(RVA = "0x21D4FF0", Offset = "0x21D50F1", VA = "0x21D4FF0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000398 RID: 920
	// (get) Token: 0x0600146C RID: 5228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000356")]
	public static string CurrentSceneNameStack
	{
		[Token(Token = "0x6001268")]
		[Address(RVA = "0x21D5060", Offset = "0x21D5161", VA = "0x21D5060")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000399 RID: 921
	// (get) Token: 0x0600146D RID: 5229 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000357")]
	public static Stack<AsyncOperationHandle<SceneInstance>> SceneAoHandleStack
	{
		[Token(Token = "0x6001269")]
		[Address(RVA = "0x21D5160", Offset = "0x21D5261", VA = "0x21D5160")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700039A RID: 922
	// (get) Token: 0x0600146E RID: 5230 RVA: 0x00009240 File Offset: 0x00007440
	[Token(Token = "0x17000358")]
	public static AsyncOperationHandle<SceneInstance> CurrentSceneAoHandleStack
	{
		[Token(Token = "0x600126A")]
		[Address(RVA = "0x21D51D0", Offset = "0x21D52D1", VA = "0x21D51D0")]
		get
		{
			return default(AsyncOperationHandle<SceneInstance>);
		}
	}

	// Token: 0x1700039B RID: 923
	// (get) Token: 0x0600146F RID: 5231 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000359")]
	public static Stack<GameObject[]> SceneStreamersStack
	{
		[Token(Token = "0x600126B")]
		[Address(RVA = "0x21D5260", Offset = "0x21D5361", VA = "0x21D5260")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700039C RID: 924
	// (get) Token: 0x06001470 RID: 5232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700035A")]
	public static Stack<string[]> AddSceneNameStack
	{
		[Token(Token = "0x600126C")]
		[Address(RVA = "0x21D52D0", Offset = "0x21D53D1", VA = "0x21D52D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700039D RID: 925
	// (get) Token: 0x06001471 RID: 5233 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700035B")]
	public static string[] CurrentAddSceneNameStack
	{
		[Token(Token = "0x600126D")]
		[Address(RVA = "0x21D5340", Offset = "0x21D5441", VA = "0x21D5340")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700039E RID: 926
	// (get) Token: 0x06001472 RID: 5234 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700035C")]
	public static Stack<AsyncOperationHandle<SceneInstance>[]> AddAoHandleStack
	{
		[Token(Token = "0x600126E")]
		[Address(RVA = "0x21D5410", Offset = "0x21D5511", VA = "0x21D5410")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700039F RID: 927
	// (get) Token: 0x06001473 RID: 5235 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700035D")]
	public static AsyncOperationHandle<SceneInstance>[] CurrentAddAoHandleStack
	{
		[Token(Token = "0x600126F")]
		[Address(RVA = "0x21D5480", Offset = "0x21D5581", VA = "0x21D5480")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001474 RID: 5236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001270")]
	[Address(RVA = "0x21D5550", Offset = "0x21D5651", VA = "0x21D5550")]
	private void Awake()
	{
	}

	// Token: 0x06001475 RID: 5237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001271")]
	[Address(RVA = "0x21D55D0", Offset = "0x21D56D1", VA = "0x21D55D0")]
	public static void InactiveSceneGameObject(Scene scene)
	{
	}

	// Token: 0x06001476 RID: 5238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001272")]
	[Address(RVA = "0x21D5A70", Offset = "0x21D5B71", VA = "0x21D5A70")]
	public static void InactiveSceneGameObject()
	{
	}

	// Token: 0x06001477 RID: 5239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001273")]
	[Address(RVA = "0x21D5C10", Offset = "0x21D5D11", VA = "0x21D5C10")]
	public static void ActiveSceneGameObject(Scene scene)
	{
	}

	// Token: 0x06001478 RID: 5240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001274")]
	[Address(RVA = "0x21D5EF0", Offset = "0x21D5FF1", VA = "0x21D5EF0")]
	public static void ActiveSceneGameObject()
	{
	}

	// Token: 0x06001479 RID: 5241 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001275")]
	[Address(RVA = "0x21D6090", Offset = "0x21D6191", VA = "0x21D6090")]
	private static void LoadAddScenes(string[] addSceneNames)
	{
	}

	// Token: 0x0600147A RID: 5242 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001276")]
	[Address(RVA = "0x21D6290", Offset = "0x21D6391", VA = "0x21D6290")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19CDD0", Offset = "0x19CED1")]
	private static IEnumerator UnloadWait(bool isUnload)
	{
		return null;
	}

	// Token: 0x0600147B RID: 5243 RVA: 0x00009258 File Offset: 0x00007458
	[Token(Token = "0x6001277")]
	[Address(RVA = "0x21D6340", Offset = "0x21D6441", VA = "0x21D6340")]
	private static bool RemoveKeepAddScene()
	{
		return default(bool);
	}

	// Token: 0x0600147C RID: 5244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001278")]
	[Address(RVA = "0x21D66F0", Offset = "0x21D67F1", VA = "0x21D66F0")]
	public static void TransitionScene(string sceneName, [Optional] Action action, [Optional] string[] addSceneNames, [Optional] Func<IEnumerator> objectLoadFunc)
	{
	}

	// Token: 0x0600147D RID: 5245 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001279")]
	[Address(RVA = "0x21D67A0", Offset = "0x21D68A1", VA = "0x21D67A0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19CE40", Offset = "0x19CF41")]
	private static IEnumerator TransitionSceneAsync(string sceneName, [Optional] Action action, [Optional] string[] addSceneNames_, [Optional] Func<IEnumerator> objectLoadFunc)
	{
		return null;
	}

	// Token: 0x0600147E RID: 5246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600127A")]
	[Address(RVA = "0x21D68A0", Offset = "0x21D69A1", VA = "0x21D68A0")]
	public static string[] AddSceneNamesFieldMap(string[] addSceneNames_)
	{
		return null;
	}

	// Token: 0x0600147F RID: 5247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127B")]
	[Address(RVA = "0x21D68B0", Offset = "0x21D69B1", VA = "0x21D68B0")]
	public static void TransitionSceneKeep(string sceneName, [Optional] Action action, [Optional] string[] addSceneNames, [Optional] Func<IEnumerator> objectLoadFunc)
	{
	}

	// Token: 0x06001480 RID: 5248 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600127C")]
	[Address(RVA = "0x21D6960", Offset = "0x21D6A61", VA = "0x21D6960")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19CEB0", Offset = "0x19CFB1")]
	private static IEnumerator TransitionSceneKeepAsync(string sceneName, [Optional] Action action, [Optional] string[] addSceneNames_, [Optional] Func<IEnumerator> objectLoadFunc)
	{
		return null;
	}

	// Token: 0x06001481 RID: 5249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127D")]
	[Address(RVA = "0x21D6A60", Offset = "0x21D6B61", VA = "0x21D6A60")]
	private static void ActiveNext(AsyncOperationHandle<SceneInstance> op)
	{
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127E")]
	[Address(RVA = "0x21D6AD0", Offset = "0x21D6BD1", VA = "0x21D6AD0")]
	private static void ActiveNext()
	{
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600127F")]
	[Address(RVA = "0x21D6D10", Offset = "0x21D6E11", VA = "0x21D6D10")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19CF20", Offset = "0x19D021")]
	private static IEnumerator LoadSceneBgm(string sceneName)
	{
		return null;
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001280")]
	[Address(RVA = "0x21D6DA0", Offset = "0x21D6EA1", VA = "0x21D6DA0")]
	private static void SetSceneBgm(string sceneName)
	{
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001281")]
	[Address(RVA = "0x21D6E00", Offset = "0x21D6F01", VA = "0x21D6E00")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19CF90", Offset = "0x19D091")]
	private static IEnumerator WaitAsyncLoad()
	{
		return null;
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001282")]
	[Address(RVA = "0x21D6E90", Offset = "0x21D6F91", VA = "0x21D6E90")]
	public static void PushStackScene(string sceneName, [Optional] Action action, [Optional] string[] addSceneNames_, [Optional] Func<IEnumerator> objectLoadFunc)
	{
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001283")]
	[Address(RVA = "0x21D75C0", Offset = "0x21D76C1", VA = "0x21D75C0")]
	public static void PopStackScene()
	{
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001284")]
	[Address(RVA = "0x21D7D60", Offset = "0x21D7E61", VA = "0x21D7D60")]
	public static void AddScene(string sceneName, [Optional] Action action, [Optional] string[] addSceneNames_, [Optional] Func<IEnumerator> objectLoadFunc)
	{
	}

	// Token: 0x06001489 RID: 5257 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001285")]
	[Address(RVA = "0x21D83B0", Offset = "0x21D84B1", VA = "0x21D83B0")]
	[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x19D000", Offset = "0x19D101")]
	private static IEnumerator WaitAsyncLoadAddScene()
	{
		return null;
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x00009270 File Offset: 0x00007470
	[Token(Token = "0x6001286")]
	[Address(RVA = "0x21D8440", Offset = "0x21D8541", VA = "0x21D8440")]
	public static bool IsTransitionCompleted(bool isCheckStreamer = true)
	{
		return default(bool);
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001287")]
	[Address(RVA = "0x21D8530", Offset = "0x21D8631", VA = "0x21D8530")]
	public static void UnloadAllScene()
	{
	}

	// Token: 0x0600148C RID: 5260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001288")]
	[Address(RVA = "0x21D9000", Offset = "0x21D9101", VA = "0x21D9000")]
	public static void BeforeSaveFieldGameData()
	{
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001289")]
	[Address(RVA = "0x21D9010", Offset = "0x21D9111", VA = "0x21D9010")]
	public static void AfterLoadFieldGameData(bool isSceneChange)
	{
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128A")]
	[Address(RVA = "0x21D9020", Offset = "0x21D9121", VA = "0x21D9020")]
	public static void InitializeForLoadGame()
	{
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128B")]
	[Address(RVA = "0x21D93B0", Offset = "0x21D94B1", VA = "0x21D93B0")]
	public SceneTransitionManager()
	{
	}

	// Token: 0x04000BA4 RID: 2980
	[Token(Token = "0x40008EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SceneTransitionManager _Outer;

	// Token: 0x04000BA5 RID: 2981
	[Token(Token = "0x40008EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static AsyncOperationHandle<SceneInstance> NextScene;

	// Token: 0x04000BA6 RID: 2982
	[Token(Token = "0x40008F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Scene RootScene;

	// Token: 0x04000BA7 RID: 2983
	[Token(Token = "0x40008F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string NextSceneName;

	// Token: 0x04000BA8 RID: 2984
	[Token(Token = "0x40008F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static List<AsyncOperationHandle<SceneInstance>> NextAddScenes;

	// Token: 0x04000BA9 RID: 2985
	[Token(Token = "0x40008F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static List<AsyncOperationHandle<SceneInstance>> UnloadScenes;

	// Token: 0x04000BAA RID: 2986
	[Token(Token = "0x40008F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static bool IsTransitionComplete;

	// Token: 0x04000BAB RID: 2987
	[Token(Token = "0x40008F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x15F6E0", Offset = "0x15F7E1")]
	private static bool <IsRemoveComplete>k__BackingField;

	// Token: 0x04000BAC RID: 2988
	[Token(Token = "0x40008F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public static bool TitleStartWithShortPlay;

	// Token: 0x04000BAD RID: 2989
	[Token(Token = "0x40008F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Stack<string> _SceneNameStack;

	// Token: 0x04000BAE RID: 2990
	[Token(Token = "0x40008F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static Stack<AsyncOperationHandle<SceneInstance>> _SceneAoHandleStack;

	// Token: 0x04000BAF RID: 2991
	[Token(Token = "0x40008F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static Stack<GameObject[]> _SceneStreamersStack;

	// Token: 0x04000BB0 RID: 2992
	[Token(Token = "0x40008FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Stack<string[]> _AddSceneNameStack;

	// Token: 0x04000BB1 RID: 2993
	[Token(Token = "0x40008FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static Stack<AsyncOperationHandle<SceneInstance>[]> _AddAoHandleStack;

	// Token: 0x04000BB2 RID: 2994
	[Token(Token = "0x40008FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static List<AsyncOperationHandle<SceneInstance>[]> KeepAddScenes;

	// Token: 0x04000BB3 RID: 2995
	[Token(Token = "0x40008FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static List<string[]> KeepAddSceneNames;

	// Token: 0x04000BB4 RID: 2996
	[Token(Token = "0x40008FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static List<SceneTransitionManager.SceneGameObjectEnabled> SceneObjectEnabledList;

	// Token: 0x04000BB5 RID: 2997
	[Token(Token = "0x40008FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static Func<IEnumerator> ObjectLoadFunc;

	// Token: 0x04000BB6 RID: 2998
	[Token(Token = "0x4000900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static Action LoadComplateAction;

	// Token: 0x02000307 RID: 775
	[Token(Token = "0x200103E")]
	public class GameObjectEnabled
	{
		// Token: 0x06001491 RID: 5265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CEF")]
		[Address(RVA = "0x21D5A20", Offset = "0x21D5B21", VA = "0x21D5A20")]
		public GameObjectEnabled(GameObject gameObject, bool enabled)
		{
		}

		// Token: 0x04000BB7 RID: 2999
		[Token(Token = "0x4018F29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject gameObject;

		// Token: 0x04000BB8 RID: 3000
		[Token(Token = "0x4018F2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool enabled;
	}

	// Token: 0x02000308 RID: 776
	[Token(Token = "0x200103F")]
	public class SceneGameObjectEnabled
	{
		// Token: 0x06001492 RID: 5266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF0")]
		[Address(RVA = "0x21D5990", Offset = "0x21D5A91", VA = "0x21D5990")]
		public SceneGameObjectEnabled()
		{
		}

		// Token: 0x04000BB9 RID: 3001
		[Token(Token = "0x4018F2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Scene scene;

		// Token: 0x04000BBA RID: 3002
		[Token(Token = "0x4018F2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<SceneTransitionManager.GameObjectEnabled> ObjectEnabledList;
	}

	// Token: 0x02000309 RID: 777
	[Token(Token = "0x2001040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157460", Offset = "0x157561")]
	private sealed class <>c__DisplayClass47_0
	{
		// Token: 0x06001493 RID: 5267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF1")]
		[Address(RVA = "0x21D5A10", Offset = "0x21D5B11", VA = "0x21D5A10")]
		public <>c__DisplayClass47_0()
		{
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x6006CF2")]
		[Address(RVA = "0x21D9790", Offset = "0x21D9891", VA = "0x21D9790")]
		internal bool <InactiveSceneGameObject>b__0(SceneTransitionManager.GameObjectEnabled o)
		{
			return default(bool);
		}

		// Token: 0x04000BBB RID: 3003
		[Token(Token = "0x4018F2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject obj;
	}

	// Token: 0x0200030A RID: 778
	[Token(Token = "0x2001041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157470", Offset = "0x157571")]
	private sealed class <UnloadWait>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x06001495 RID: 5269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF3")]
		[Address(RVA = "0x21D6310", Offset = "0x21D6411", VA = "0x21D6310")]
		[DebuggerHidden]
		public <UnloadWait>d__52(int <>1__state)
		{
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF4")]
		[Address(RVA = "0x21DB7E0", Offset = "0x21DB8E1", VA = "0x21DB7E0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x6006CF5")]
		[Address(RVA = "0x21DB8B0", Offset = "0x21DB9B1", VA = "0x21DB8B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF6")]
		[Address(RVA = "0x21DB850", Offset = "0x21DB951", VA = "0x21DB850")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BFF")]
		private object Current
		{
			[Token(Token = "0x6006CF7")]
			[Address(RVA = "0x21DBD10", Offset = "0x21DBE11", VA = "0x21DBD10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF8")]
		[Address(RVA = "0x21DBD20", Offset = "0x21DBE21", VA = "0x21DBD20", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C00")]
		private object Current
		{
			[Token(Token = "0x6006CF9")]
			[Address(RVA = "0x21DBD80", Offset = "0x21DBE81", VA = "0x21DBD80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BBC RID: 3004
		[Token(Token = "0x4018F2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4018F2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4018F30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isUnload;

		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4018F31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<AsyncOperationHandle<SceneInstance>>.Enumerator <>7__wrap1;

		// Token: 0x04000BC0 RID: 3008
		[Token(Token = "0x4018F32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AsyncOperationHandle<SceneInstance> <asyncOperation>5__3;
	}

	// Token: 0x0200030B RID: 779
	[Token(Token = "0x2001042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157480", Offset = "0x157581")]
	private sealed class <TransitionSceneAsync>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x0600149C RID: 5276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CFA")]
		[Address(RVA = "0x21D6870", Offset = "0x21D6971", VA = "0x21D6870")]
		[DebuggerHidden]
		public <TransitionSceneAsync>d__55(int <>1__state)
		{
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CFB")]
		[Address(RVA = "0x21D99D0", Offset = "0x21D9AD1", VA = "0x21D99D0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x6006CFC")]
		[Address(RVA = "0x21D99E0", Offset = "0x21D9AE1", VA = "0x21D99E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C01")]
		private object Current
		{
			[Token(Token = "0x6006CFD")]
			[Address(RVA = "0x21DA8D0", Offset = "0x21DA9D1", VA = "0x21DA8D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CFE")]
		[Address(RVA = "0x21DA8E0", Offset = "0x21DA9E1", VA = "0x21DA8E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C02")]
		private object Current
		{
			[Token(Token = "0x6006CFF")]
			[Address(RVA = "0x21DA940", Offset = "0x21DAA41", VA = "0x21DA940", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BC1 RID: 3009
		[Token(Token = "0x4018F33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000BC2 RID: 3010
		[Token(Token = "0x4018F34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000BC3 RID: 3011
		[Token(Token = "0x4018F35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] addSceneNames_;

		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4018F36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sceneName;

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4018F37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Func<IEnumerator> objectLoadFunc;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4018F38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action action;
	}

	// Token: 0x0200030C RID: 780
	[Token(Token = "0x2001043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157490", Offset = "0x157591")]
	private sealed class <TransitionSceneKeepAsync>d__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060014A2 RID: 5282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D00")]
		[Address(RVA = "0x21D6A30", Offset = "0x21D6B31", VA = "0x21D6A30")]
		[DebuggerHidden]
		public <TransitionSceneKeepAsync>d__58(int <>1__state)
		{
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D01")]
		[Address(RVA = "0x21DA950", Offset = "0x21DAA51", VA = "0x21DA950", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x6006D02")]
		[Address(RVA = "0x21DA960", Offset = "0x21DAA61", VA = "0x21DA960", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C03")]
		private object Current
		{
			[Token(Token = "0x6006D03")]
			[Address(RVA = "0x21DB760", Offset = "0x21DB861", VA = "0x21DB760", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D04")]
		[Address(RVA = "0x21DB770", Offset = "0x21DB871", VA = "0x21DB770", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C04")]
		private object Current
		{
			[Token(Token = "0x6006D05")]
			[Address(RVA = "0x21DB7D0", Offset = "0x21DB8D1", VA = "0x21DB7D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4018F39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4018F3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4018F3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] addSceneNames_;

		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4018F3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string sceneName;

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4018F3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Func<IEnumerator> objectLoadFunc;

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4018F3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action action;

		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4018F3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string[] <addSceneNames>5__2;
	}

	// Token: 0x0200030D RID: 781
	[Token(Token = "0x2001044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1574A0", Offset = "0x1575A1")]
	private sealed class <LoadSceneBgm>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060014A8 RID: 5288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D06")]
		[Address(RVA = "0x21D6D70", Offset = "0x21D6E71", VA = "0x21D6D70")]
		[DebuggerHidden]
		public <LoadSceneBgm>d__61(int <>1__state)
		{
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D07")]
		[Address(RVA = "0x21D98A0", Offset = "0x21D99A1", VA = "0x21D98A0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x6006D08")]
		[Address(RVA = "0x21D98B0", Offset = "0x21D99B1", VA = "0x21D98B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C05")]
		private object Current
		{
			[Token(Token = "0x6006D09")]
			[Address(RVA = "0x21D9950", Offset = "0x21D9A51", VA = "0x21D9950", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0A")]
		[Address(RVA = "0x21D9960", Offset = "0x21D9A61", VA = "0x21D9960", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C06")]
		private object Current
		{
			[Token(Token = "0x6006D0B")]
			[Address(RVA = "0x21D99C0", Offset = "0x21D9AC1", VA = "0x21D99C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4018F40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000BCF RID: 3023
		[Token(Token = "0x4018F41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;
	}

	// Token: 0x0200030E RID: 782
	[Token(Token = "0x2001045")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1574B0", Offset = "0x1575B1")]
	private sealed class <WaitAsyncLoad>d__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060014AE RID: 5294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0C")]
		[Address(RVA = "0x21D6E60", Offset = "0x21D6F61", VA = "0x21D6E60")]
		[DebuggerHidden]
		public <WaitAsyncLoad>d__63(int <>1__state)
		{
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0D")]
		[Address(RVA = "0x21DBD90", Offset = "0x21DBE91", VA = "0x21DBD90", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x6006D0E")]
		[Address(RVA = "0x21DBF10", Offset = "0x21DC011", VA = "0x21DBF10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0F")]
		[Address(RVA = "0x21DBE50", Offset = "0x21DBF51", VA = "0x21DBE50")]
		private void <>m__Finally1()
		{
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D10")]
		[Address(RVA = "0x21DBEB0", Offset = "0x21DBFB1", VA = "0x21DBEB0")]
		private void <>m__Finally2()
		{
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C07")]
		private object Current
		{
			[Token(Token = "0x6006D11")]
			[Address(RVA = "0x21DCC40", Offset = "0x21DCD41", VA = "0x21DCC40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D12")]
		[Address(RVA = "0x21DCC50", Offset = "0x21DCD51", VA = "0x21DCC50", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C08")]
		private object Current
		{
			[Token(Token = "0x6006D13")]
			[Address(RVA = "0x21DCCB0", Offset = "0x21DCDB1", VA = "0x21DCCB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BD0 RID: 3024
		[Token(Token = "0x4018F42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000BD1 RID: 3025
		[Token(Token = "0x4018F43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4018F44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private NpcLifecycleController <npcLifecycleController>5__2;

		// Token: 0x04000BD3 RID: 3027
		[Token(Token = "0x4018F45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperation <async>5__3;

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4018F46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<AsyncOperationHandle<SceneInstance>>.Enumerator <>7__wrap3;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4018F47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AsyncOperationHandle<SceneInstance> <aoHandle>5__5;
	}

	// Token: 0x0200030F RID: 783
	[Token(Token = "0x2001046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1574C0", Offset = "0x1575C1")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x060014B7 RID: 5303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D15")]
		[Address(RVA = "0x21D96E0", Offset = "0x21D97E1", VA = "0x21D96E0")]
		public <>c()
		{
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D16")]
		[Address(RVA = "0x21D96F0", Offset = "0x21D97F1", VA = "0x21D96F0")]
		internal void <PushStackScene>b__64_0(AsyncOperationHandle<SceneInstance> op)
		{
		}

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4018F48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SceneTransitionManager.<>c <>9;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4018F49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<AsyncOperationHandle<SceneInstance>> <>9__64_0;
	}

	// Token: 0x02000310 RID: 784
	[Token(Token = "0x2001047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1574D0", Offset = "0x1575D1")]
	private sealed class <>c__DisplayClass66_0
	{
		// Token: 0x060014B9 RID: 5305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D17")]
		[Address(RVA = "0x21D83A0", Offset = "0x21D84A1", VA = "0x21D83A0")]
		public <>c__DisplayClass66_0()
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D18")]
		[Address(RVA = "0x21D9820", Offset = "0x21D9921", VA = "0x21D9820")]
		internal void <AddScene>b__0(AsyncOperationHandle<SceneInstance> op)
		{
		}

		// Token: 0x04000BD8 RID: 3032
		[Token(Token = "0x4018F4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sceneName;
	}

	// Token: 0x02000311 RID: 785
	[Token(Token = "0x2001048")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1574E0", Offset = "0x1575E1")]
	private sealed class <WaitAsyncLoadAddScene>d__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		// Token: 0x060014BB RID: 5307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D19")]
		[Address(RVA = "0x21D8410", Offset = "0x21D8511", VA = "0x21D8410")]
		[DebuggerHidden]
		public <WaitAsyncLoadAddScene>d__67(int <>1__state)
		{
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1A")]
		[Address(RVA = "0x21DCCC0", Offset = "0x21DCDC1", VA = "0x21DCCC0", Slot = "5")]
		[DebuggerHidden]
		private void Dispose()
		{
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x6006D1B")]
		[Address(RVA = "0x21DCCD0", Offset = "0x21DCDD1", VA = "0x21DCCD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C09")]
		private object Current
		{
			[Token(Token = "0x6006D1C")]
			[Address(RVA = "0x21DD2D0", Offset = "0x21DD3D1", VA = "0x21DD2D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D1D")]
		[Address(RVA = "0x21DD2E0", Offset = "0x21DD3E1", VA = "0x21DD2E0", Slot = "8")]
		[DebuggerHidden]
		private void Reset()
		{
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C0A")]
		private object Current
		{
			[Token(Token = "0x6006D1E")]
			[Address(RVA = "0x21DD340", Offset = "0x21DD441", VA = "0x21DD340", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		// Token: 0x04000BD9 RID: 3033
		[Token(Token = "0x4018F4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		// Token: 0x04000BDA RID: 3034
		[Token(Token = "0x4018F4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4018F4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AsyncOperationHandle<SceneInstance>[] <>7__wrap1;

		// Token: 0x04000BDC RID: 3036
		[Token(Token = "0x4018F4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <>7__wrap2;

		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4018F4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AsyncOperationHandle<SceneInstance> <asyncOperation>5__4;

		// Token: 0x04000BDE RID: 3038
		[Token(Token = "0x4018F50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AsyncOperation <async>5__5;
	}
}
