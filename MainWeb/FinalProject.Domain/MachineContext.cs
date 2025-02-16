﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Domain
{
    public class MachineContext : DbContext
    {
        public DbSet<GymMachine> GymMachines { get; set; } 

        public MachineContext(DbContextOptions<MachineContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GymMachine>().HasData(
                new GymMachine
                {
                    Id = 1,
                    Name = "bench_press",
                    Description = "The bench press is a classic strength training exercise that primarily targets the chest muscles, but it also engages the triceps and shoulders. It is performed lying on a flat bench while lifting a weighted barbell upward from the chest. It is essential for developing strength and muscle mass in the upper body.",
                    UsingSteps = new string[]
                    {
                        "Adjust the bench and load the bar. Make sure the weight plates are secured.",
                        "Lie on the bench, feet on the floor, back slightly arched. Grip the bar with your hands slightly wider than shoulder-width apart.",
                        "Lift the bar from the rack and position it directly above your chest, arms extended.",
                        "Slowly lower the bar until it lightly touches your chest, controlling the movement.",
                        "Push the bar back up, extending your arms without locking your elbows.",
                        "Repeat the movement, and once finished, place the bar back on the rack."
                    }
                },
                new GymMachine
                {
                    Id = 2,
                    Name = "elliptical",
                    Description = "The elliptical machine is a low-impact cardiovascular exercise machine that simulates walking, running, or climbing stairs. It provides a full-body workout by engaging both the upper body (with movable handles) and the lower body (with foot pedals). The elliptical offers an effective way to improve cardiovascular endurance, burn calories, and strengthen muscles without putting excessive strain on the joints.",
                    UsingSteps = new string[]
                    {
                        "Adjust the resistance and incline (if available) to your fitness level. Ensure the machine is properly set up for your height.",
                        "Step onto the foot pedals, holding the handles for support. Start with one foot and then the other, making sure you're balanced.",
                        "Begin pedaling by moving your feet in an elliptical (circular) motion. Keep your posture upright and your core engaged.",
                        "Grip the handles and move them in sync with your legs, pulling and pushing as you pedal to engage your arms and upper body.",
                        "Maintain a steady pace, adjusting the resistance or incline as needed for more intensity.",
                        "After finishing your workout, reduce the resistance and slow down your pace for a couple of minutes before stepping off the machine."
                    }
                },
                new GymMachine
                {
                    Id = 3,
                    Name = "treadmill",
                    Description = "A treadmill is a cardio machine used for walking, jogging, or running on a moving belt. It helps improve endurance, burn calories, and strengthen the lower body.",
                    UsingSteps = new string[]
                    {
                        "Adjust speed and incline. Start slow.",
                        "Stand on the side rails, press start, then step onto the belt at a low speed.",
                        "Gradually increase speed or incline as you feel comfortable.",
                        "Stay upright with a relaxed posture, avoiding leaning on the handrails.",
                        "Slow down the speed to walk before stopping.",
                        "Press stop, wait for the belt to stop, then step off."
                    }
                },
                new GymMachine
                {
                    Id = 4,
                    Name = "deadlift",
                    Description = "The deadlift is a fundamental strength exercise that targets multiple muscle groups, primarily the lower back, glutes, hamstrings, and core. It involves lifting a weighted barbell from the ground to hip level by hinging at the hips and engaging the legs and back.",
                    UsingSteps = new string[]
                    {
                        "Stand with feet shoulder-width apart, barbell over the middle of your feet. Bend down, grip the bar slightly outside your knees.",
                        "Keep your back straight, chest up, and shoulders over the bar. Hinge at the hips and slightly bend your knees.",
                        "Push through your heels, extend your hips, and lift the barbell up, keeping it close to your body.",
                        "Stand fully upright with the barbell at hip height, shoulders back, and core tight.",
                        "Reverse the motion by hinging at the hips and bending your knees to lower the bar back to the ground.",
                        "Complete the desired number of repetitions, maintaining proper form."
                    }
                },
                new GymMachine
                {
                    Id = 5,
                    Name = "pulldown",
                    Description = "The lat pulldown is a strength exercise that targets the muscles of the upper back, primarily the latissimus dorsi. It involves pulling a bar down towards your chest while seated, simulating a pull-up motion. This exercise helps improve upper body strength and posture.",
                    UsingSteps = new string[]
                    {
                        "Adjust the knee pad to secure your legs. Grip the bar slightly wider than shoulder-width.",
                        "Sit upright with your arms fully extended, core tight, and shoulders slightly back.",
                        "Pull the bar down towards your upper chest, leading with your elbows and keeping your back straight.",
                        "Hold briefly when the bar reaches your chest, squeezing your shoulder blades together.",
                        "Slowly extend your arms, letting the bar rise back to the starting position in a controlled motion.",
                        "Complete the desired number of repetitions while maintaining good form."
                    }
                },
                new GymMachine
                {
                    Id = 6,
                    Name = "peck_deck",
                    Description = "The peck deck is a machine designed to isolate and target the chest muscles, specifically the pectoralis major. It mimics the motion of a chest fly, helping to build strength and definition in the chest by bringing the arms together in a controlled motion.",
                    UsingSteps = new string[]
                    {
                        "Adjust the seat height so that your arms are parallel to the floor when gripping the handles. Position your back flat against the seat pad.",
                        "Sit upright, grasp the handles with your elbows slightly bent, and keep your feet flat on the floor.",
                        "Bring the handles together in front of your chest in a smooth, controlled motion, focusing on squeezing your chest muscles.",
                        "Hold for a brief second when the handles meet, ensuring full contraction of the chest.",
                        "Slowly return to the starting position, allowing the arms to open up without overstretching the chest.",
                        "Perform the desired number of repetitions, maintaining control and good form throughout."
                    }
                }
            );
        }
    }
}
