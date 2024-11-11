package com.example.newsapp;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.fragment.app.FragmentManager;
import androidx.lifecycle.Lifecycle;
import androidx.viewpager2.adapter.FragmentStateAdapter;

public class NewsAdapter extends FragmentStateAdapter {

    public NewsAdapter(@NonNull FragmentManager fragmentManager, @NonNull Lifecycle lifecycle) {
        super(fragmentManager, lifecycle);
    }

    @NonNull
    @Override
    public Fragment createFragment(int position) {
        switch (position) {
            case 0: {
                return new TopStoriesFragment();
            } case 1: {
                return new SportsFragment();
            } case 2: {
                return new TechnologyFragment();
            } default: {
                return null;
            }
        }
    }

    @Override
    public int getItemCount() {
        return 3;
    }
}
