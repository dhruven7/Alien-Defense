using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public interface BombSubject
{
    void attach(BombObserver observer);
    void detach(BombObserver observer);
    void notifyAll();
}