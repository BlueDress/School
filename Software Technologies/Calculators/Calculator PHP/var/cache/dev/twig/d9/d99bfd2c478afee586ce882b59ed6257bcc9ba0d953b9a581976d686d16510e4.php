<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_0842eb3a797da5479696ceb379c08776e2239756bb56ff207584b3f80ef51324 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_a17b9a33d8cef826431bd6bb72e51cb1a8a3225e8e58d8fcd19c5cf1bebd81ab = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a17b9a33d8cef826431bd6bb72e51cb1a8a3225e8e58d8fcd19c5cf1bebd81ab->enter($__internal_a17b9a33d8cef826431bd6bb72e51cb1a8a3225e8e58d8fcd19c5cf1bebd81ab_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_a17b9a33d8cef826431bd6bb72e51cb1a8a3225e8e58d8fcd19c5cf1bebd81ab->leave($__internal_a17b9a33d8cef826431bd6bb72e51cb1a8a3225e8e58d8fcd19c5cf1bebd81ab_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_a3f0a091fe882d9523b3d3d49d429cb1a9e477bc4e2a1f3ce37e76fee65a0545 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a3f0a091fe882d9523b3d3d49d429cb1a9e477bc4e2a1f3ce37e76fee65a0545->enter($__internal_a3f0a091fe882d9523b3d3d49d429cb1a9e477bc4e2a1f3ce37e76fee65a0545_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_a3f0a091fe882d9523b3d3d49d429cb1a9e477bc4e2a1f3ce37e76fee65a0545->leave($__internal_a3f0a091fe882d9523b3d3d49d429cb1a9e477bc4e2a1f3ce37e76fee65a0545_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_7f420638853d533940322b1015ed70611c4d884634c84a943bd519941b86c333 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7f420638853d533940322b1015ed70611c4d884634c84a943bd519941b86c333->enter($__internal_7f420638853d533940322b1015ed70611c4d884634c84a943bd519941b86c333_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_7f420638853d533940322b1015ed70611c4d884634c84a943bd519941b86c333->leave($__internal_7f420638853d533940322b1015ed70611c4d884634c84a943bd519941b86c333_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_cbf6eafd4650dc7ce6ea5a1a5d620e5bf4d3743fd0d6e3e251115b06f3a162d7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cbf6eafd4650dc7ce6ea5a1a5d620e5bf4d3743fd0d6e3e251115b06f3a162d7->enter($__internal_cbf6eafd4650dc7ce6ea5a1a5d620e5bf4d3743fd0d6e3e251115b06f3a162d7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_cbf6eafd4650dc7ce6ea5a1a5d620e5bf4d3743fd0d6e3e251115b06f3a162d7->leave($__internal_cbf6eafd4650dc7ce6ea5a1a5d620e5bf4d3743fd0d6e3e251115b06f3a162d7_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  117 => 33,  114 => 32,  108 => 28,  106 => 27,  102 => 25,  96 => 24,  88 => 21,  82 => 17,  80 => 16,  75 => 14,  70 => 13,  64 => 12,  54 => 9,  48 => 6,  45 => 5,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
";
    }
}
