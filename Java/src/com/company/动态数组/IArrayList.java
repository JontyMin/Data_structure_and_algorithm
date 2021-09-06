package com.company.动态数组;

public interface IArrayList {

    void clear();

    int size();

    boolean isEmpty();

    boolean contains(int element);

    void add(int element);

    int get(int index);

    int set(int index,int element);

    int add(int index,int element);

    int remove(int index);

    int indexOf(int element);
}
