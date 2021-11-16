using ClickerGame.Models;
using UnityEngine;
using UnityEngine.UI;

public class HomeScene : MonoBehaviour
{
    [SerializeField]
    private ScoreView _score = null;

    [SerializeField]
    private Button _scoreButton = null;

    [SerializeField]
    private CurrencyType _currencyType = CurrencyType.None;

    [SerializeField]
    private double _quantity = 1;

    [SerializeField]
    private GameObject _virusObj;

    [SerializeField]
    private GameObject _spawner;
    [SerializeField]
    float speed;
    [SerializeField]
    private GameObject _parent;
    private float repeat = 2f; // 何周期するか
    float oneCycle = 2.0f * Mathf.PI; // sin の周期は 2π
    void Start()
    {
        var game = Game.Instance;
        _score.DataSource = game.CashInventory;

        var e = new Button.ButtonClickedEvent();
        e.AddListener(() =>
        {
            var c = new Currency(_currencyType, _quantity);
            var cc = game.CashInventory.Add(c);
            for (int i = 0; i < 5; i++)
            {
                GameObject copy = Instantiate(_virusObj, _parent.transform);
                copy.transform.localPosition = _spawner.transform.localPosition;
                var point = ((float)i / 5) * oneCycle; // 周期の位置 (1.0 = 100% の時 2π となる)
                var repeatPoint = point * repeat; // 繰り返し位置

                var x = Mathf.Cos(repeatPoint);
                var y = Mathf.Sin(repeatPoint);

                var position = new Vector3(x, y);
                //var angles = new Vector3(0, 72 * i, 0);
                //var direction = Quaternion.Euler(angles) * Vector3.forward;
                copy.GetComponent<Rigidbody2D>().AddForce(position * speed, ForceMode2D.Impulse);
            }
        });
        _scoreButton.onClick = e;
    }
}